using Auction.Core.Data;
using Auction.Core.Entities;
using AuctionWebApi.Domain.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly AuctionDBContext _dbContext;
        public ProductoController(AuctionDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Producto>> GetAll()
        {
            return _dbContext.Productos;
        }

        [HttpGet("User/{UserId}")]
        public ActionResult<IEnumerable<Producto>> GetAllProductsOfUser(int UserId)
        {
            return _dbContext.Productos.Where(p => p.IdUsuario == UserId).ToList();
        }

        [HttpGet("bid/{ProdID}")]
        public async Task<ActionResult<decimal?>> GetHighestBid(int ProdID)
        {
            return await _dbContext.Productos
                                            .Where(p => p.IdProducto == ProdID)
                                            .Include(p => p.Ofertas)
                                            .Select(p => p.Ofertas
                                            .OrderByDescending(o => o.Monto)
                                            .Select(o => o.Monto)
                                            .FirstOrDefault())
                                            .FirstOrDefaultAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producto?>> GetById(int id)
        {
            var producto = await _dbContext.Productos
                .SingleOrDefaultAsync(x => x.IdProducto == id);

            if (producto == null)
            {
                return NotFound();
            }

            return producto;
        }

        [HttpGet("ofertados/{userid}")]
        public ActionResult<IEnumerable<Producto>> GetAllBidded(int userid)
        {
            return _dbContext.Productos.Where(p => p.Ofertas.Any(o => o.IdUsuario == userid))
                                                        .Include(p => p.Ofertas.Where(o => o.IdUsuario == userid))
                                                        .ToList();
        }

        [HttpGet("ofertas/{id}")]
        public async Task<int> GetOfertas(int id)
        {
            var cantidad = await _dbContext.Productos.Where(p => p.IdProducto == id && p.Ofertas.Any()).SelectMany(p => p.Ofertas).CountAsync();

            return cantidad;
        }

        [HttpGet("sold/{id}")]
        public async Task<string> GetSoldStatus(int id)
        {
            string status;
            var isSubastaover = await _dbContext.Subastas.Where(s => s.Productos.Any(p => p.IdProducto.Equals(id)) && s.FechaCierre < DateTime.Now).AnyAsync();

            if (await _dbContext.Productos.Where(p => p.IdProducto == id && p.Ofertas.Any()).AnyAsync())
            {
                if (isSubastaover)
                {
                    status = "sold";
                    return status;
                }
                else
                {
                    status = "ongoing";
                    return status;
                }
            }
            else
            {
                if (isSubastaover)
                {
                    status = "notsold";
                    return status;
                }
                else
                {
                    status = "ongoingnotsold";
                    return status;
                }

            }

        }

        [HttpGet("winners/{id}")]
        public async Task<List<ProductoWinner>> GetWinners(int id)
        {
            var productos = await _dbContext.Productos
                                                    .Where(p => p.IdSubasta == id && p.EstadoDeSolicitud == true)
                                                    .Include(p => p.Ofertas.OrderByDescending(o => o.Monto).ThenBy(o => o.Fecha))
                                                    .ThenInclude(o => o.Usuario)
                                                    .ToListAsync();

            var Winners = new List<ProductoWinner>();

            foreach (var producto in productos)
            {
                var Winner = new ProductoWinner()
                {
                    Nombre = producto.Nombre,
                    Descripcion = producto.Descripcion,
                    PrecioBase = producto.PrecioBase,
                    ImageExtension = producto.ImageExtension,
                    Imagen = producto.Imagen,
                    HasGanador = producto.Ofertas.Any()
                };

                if (Winner.HasGanador)
                {
                    var bestoferta = producto.Ofertas.First();
                    Winner.NombreGanador = bestoferta.Usuario.Nombre;
                    Winner.ApellidoGanador = bestoferta.Usuario.Apellido;
                    Winner.Monto = bestoferta.Monto;
                    Winner.TotalDeOfertas = producto.Ofertas.Count;
                }

                Winners.Add(Winner);
            }

            return Winners;
        }

        [HttpGet("cantidad/")]
        public async Task<ActionResult<int?>> ProductoCount()
        {
            return await _dbContext.Productos.CountAsync();
        }

        [HttpPost("{UserId}/{SubastaId}")]
        public async Task<ActionResult> CreateProduct(int UserId, int SubastaId, ProductoDTO producto)
        {
            try
            {
                var newProducto = MapProductoObject(producto);
                newProducto.IdSubasta = SubastaId;
                newProducto.IdUsuario = UserId;
                newProducto.ImageExtension = producto.ImageExtension;
                newProducto.Imagen = producto.Imagen;
                await _dbContext.Productos.AddAsync(newProducto);
                await _dbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(GetById), new { id = newProducto.IdProducto }, newProducto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Message = "An error occurred while uploading the Producto",
                    Error = ex.Message
                });
            }
        }

        [HttpPut("{id}/{subastaId}")]
        public async Task<ActionResult> UpdateProduct(ProductoDTO producto, int id, int subastaId)
        {
            var newProducto = MapProductoObject(producto);
            newProducto.IdSubasta = subastaId;
            newProducto.IdProducto = id;
            newProducto.ImageExtension = producto.ImageExtension;
            newProducto.Imagen = producto.Imagen;
            newProducto.IdUsuario = await _dbContext.Productos.Where(x => x.IdProducto == id).Select(x => x.IdUsuario).FirstOrDefaultAsync();
            _dbContext.Productos.Update(newProducto);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var ProducttoDelete = await GetById(id);
            if (ProducttoDelete.Value is null)
            {
                return NotFound();
            }
            _dbContext.Remove(ProducttoDelete.Value);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        private Producto MapProductoObject(ProductoDTO producto)
        {
            var result = new Producto();
            result.Nombre = producto.Nombre;
            result.Descripcion = producto.Descripcion;
            result.PrecioBase = producto.PrecioBase;
            result.FechaSolicitud = producto.FechaSolicitud;
            return result;
        }
    }
}
