using Auction.Core.Data;
using Auction.Core.Entities;
using AuctionWebApi.Domain.DTO;
using AuctionWebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AuctionWebApi.Services
{
    public class SubastaService : ISubastaService
    {
        private readonly AuctionDBContext _dbContext;

        public SubastaService(AuctionDBContext context)
        {
            _dbContext = context;
        }

        public async Task<IEnumerable<Subasta>> GetSubastasToCloseAsync(DateTime currentTime)
        {
            return await _dbContext.Subastas
                                            .Where(s => s.FechaCierre <= currentTime && (s.Estado == true))
                                            .ToListAsync();
        }

        public async Task<IEnumerable<Subasta>> GetSubastasToOpenAsync(DateTime currentTime)
        {
            return await _dbContext.Subastas
                                            .Where(s => s.FechaInicio <= currentTime && s.Estado == null)
                                            .ToListAsync();
        }

        public async Task CloseSubastaAsync(Subasta subasta)
        {
            subasta.Estado = false;

            var productos = await _dbContext.Productos
                                                    .Where(p => p.IdSubasta == subasta.IdSubasta && p.Ofertas.Any())
                                                    .Include(p => p.Ofertas
                                                    .OrderByDescending(o => o.Monto)
                                                    .ThenBy(o => o.Fecha))
                                                    .ThenInclude(o => o.Usuario)
                                                    .ToListAsync();
            if(productos is not null)
            {

                await GenerateFacturas(productos, subasta.FechaCierre);
            }

            _dbContext.Subastas.Update(subasta);
            await _dbContext.SaveChangesAsync();
        }

        public async Task OpenSubastaAsync(Subasta subasta)
        {
            subasta.Estado = true;
            _dbContext.Subastas.Update(subasta);
            await _dbContext.SaveChangesAsync();
        }


            public async Task GenerateFacturas(List<Producto>? productos, DateTime fecha)
        {
            if (productos is not null)
            {
                foreach (var producto in productos)
                {

                    if (!_dbContext.DetalleVentas.Where(d=> d.IdProducto.Equals(producto.IdProducto)).Any())
                    {
                        if (!producto.Vendido)
                        {
                            producto.Vendido = true;
                            _dbContext.Productos.Update(producto);
                        }

                        var newDetalle = new DetalleVenta()
                        {
                            CuilComprador = producto.Ofertas.Select(o => o.Usuario.Cuil).FirstOrDefault(),
                            idUsuario = producto.IdUsuario,
                            Fecha = fecha,
                            Total = producto.Ofertas.Select(o => o.Monto).FirstOrDefault(),
                            IdProducto = producto.IdProducto
                        };


                        await _dbContext.DetalleVentas.AddAsync(newDetalle);
                        await _dbContext.SaveChangesAsync();
                    }

                }
            }
        }
    }
}
