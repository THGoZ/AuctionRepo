using Auction.Core.Data.Interfaces;
using Auction.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auction.Core.Data
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly AuctionDBContext _dbContext;

        public AuctionRepository(AuctionDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Producto> GetProductos()
        {
            var subastasConProductos = _dbContext.Subastas
                .Include(s => s.Productos)
                .ToList();


            if (subastasConProductos == null || subastasConProductos.Count == 0)
            {
                throw new InvalidOperationException("No se encontraron subastas con productos en la base de datos.");
            }

            var productos = subastasConProductos.SelectMany(s => s.Productos).ToList();

            if (productos == null || productos.Count == 0)
            {
                throw new InvalidOperationException("No se encontraron productos en la base de datos.");
            }

            return productos;
        }

        public List<Subasta> GetSubastas()
        {
            return [.. _dbContext.Subastas];
        }

        public List<Oferta> GetOfertas()
        {

            var ofertasPorSubasta = _dbContext.Subastas
                .Include(s => s.Productos)
                    .ThenInclude(p => p.Ofertas)
                        .ThenInclude(o => o.Usuario)
                .ToList()
                .SelectMany(s => s.Productos)
                .SelectMany(p => p.Ofertas)
                .Where(o => o.Usuario != null && o.Producto != null)
                .ToList();

            return ofertasPorSubasta;
        }

        public List<ProductoWinner> GetProductoWinners()
        {
            var productosConGanadores = _dbContext.Productos
           .Include(p => p.Ofertas)
           .ThenInclude(o => o.Usuario)
           .Where(p => p.Ofertas.Any())
           .Select(p => new ProductoWinner
           {
               Nombre = p.Nombre,
               Descripcion = p.Descripcion,
               PrecioBase = p.PrecioBase,
               Imagen = p.Imagen,
               ImageExtension = p.ImageExtension,
               HasGanador = p.Ofertas.Any(),
               NombreGanador = p.Ofertas.OrderByDescending(o => o.Monto).FirstOrDefault().Usuario.Nombre, // Tomar el nombre del usuario de la mejor oferta
               ApellidoGanador = p.Ofertas.OrderByDescending(o => o.Monto).FirstOrDefault().Usuario.Apellido,
               Monto = p.Ofertas.OrderByDescending(o => o.Monto).FirstOrDefault().Monto,
               Fecha = p.Ofertas.OrderByDescending(o => o.Monto).FirstOrDefault().Fecha,
               TotalDeOfertas = p.Ofertas.Count
           })
        .ToList();

            return productosConGanadores;
        }

        public void UpdateSubasta(Subasta subasta)
        {

            _dbContext.Entry(subasta).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public List<Producto> GetProductosSolicitados()
        {
            // Obtener todos los productos que han sido solicitados
            var productosSolicitados = _dbContext.Productos
                .Where(p => p.EstadoDeSolicitud == null) // Filtro por productos solicitados
                .ToList();

            return productosSolicitados;
        }

        public void ActualizarEstadoProducto(Producto producto)
        {
            // Obtener el producto desde la base de datos
            var productoExistente = _dbContext.Productos.FirstOrDefault(p => p.IdProducto == producto.IdProducto);

            if (productoExistente != null)
            {
                // Actualizar el estado de solicitud del producto
                productoExistente.EstadoDeSolicitud = producto.EstadoDeSolicitud;

                // Guardar los cambios en la base de datos
                _dbContext.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("No se encontró el producto en la base de datos.");
            }
        }

        public void AddSubasta(Subasta subasta)
        {
            _dbContext.Subastas.Add(subasta);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public Subasta GetSubastaById(int id)
        {
            try
            {
                var subasta = _dbContext.Subastas.Where(x => x.IdSubasta == id).Include(x => x.Productos).ThenInclude(p => p.Ofertas).SingleOrDefault();

                return subasta ?? throw new KeyNotFoundException($"Subasta con el Id {id} no se encontró.");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al traer la subasta: {ex.Message}", ex);
            }
        }

        public List<Subasta> GetSuccessfulSubastas()
        {
            try
            {
                var subasta = _dbContext.Subastas
                                                .Include(s => s.Productos)
                                                .Where(s => s.FechaCierre < DateTime.Now &&
                                                                                            s.Productos != null &&
                                                                                            s.Productos.Any(p => p != null &&
                                                                                            p.Ofertas != null &&
                                                                                            p.Ofertas.Count != 0))
                                                                                            .ToList();

                return subasta;
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error accessing related data", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving subastas", ex);
            }
        }

    }
}
