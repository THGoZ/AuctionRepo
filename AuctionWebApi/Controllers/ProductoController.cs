using Auction.Core.Data;
using Auction.Core.Entities;
using AuctionWebApi.Domain.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("ofertas/{id}")]
        public async Task<int> GetOfertas(int id)
        {
            var cantidad = await _dbContext.Productos.Where(p => p.IdProducto == id && p.Ofertas.Any()).SelectMany(p => p.Ofertas).CountAsync();

            return cantidad;
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
            result.EstadoDeSolicitud = producto.EstadoDeSolicitud;
            return result;
        }
    }
}
