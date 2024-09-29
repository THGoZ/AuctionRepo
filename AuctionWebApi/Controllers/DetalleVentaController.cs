using Auction.Core.Data;
using Auction.Core.Entities;
using AuctionWebApi.Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleVentaController : ControllerBase
    {

        private readonly AuctionDBContext _dbContext;
        public DetalleVentaController(AuctionDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<DetalleVenta> Get()
        {
            return _dbContext.DetalleVentas;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleVenta?>> Get(int id)
        {
            var detalle = await _dbContext.DetalleVentas
                .SingleOrDefaultAsync(x => x.IdDetalleVenta == id);

            if (detalle == null)
            {
                return NotFound();
            }

            return detalle;
        }

        [HttpPost("{idproducto}")]
        public async Task<ActionResult> Post(int idproducto)
        {
            var productodata = await _dbContext.Productos
                .Where(p => p.IdProducto == idproducto)
                .Include(p => p.Ofertas
                .OrderByDescending(o => o.Monto)
                .ThenBy(o => o.Fecha))
                .ThenInclude(o => o.Usuario)
                .SingleOrDefaultAsync();
            var fecha = await _dbContext.Subastas.Where(s=> s.IdSubasta == productodata.IdSubasta).Select(s=> s.FechaCierre).FirstOrDefaultAsync();

            var newDetalle = new DetalleVenta()
            {
                CuilComprador = productodata.Ofertas.Select(o => o.Usuario.Cuil).FirstOrDefault(),
                idUsuario = productodata.IdUsuario,
                Fecha = fecha,
                Total = productodata.Ofertas.Select(o => o.Monto).FirstOrDefault(),
                IdProducto = productodata.IdProducto
            };

            await _dbContext.DetalleVentas.AddAsync(newDetalle);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = newDetalle.IdDetalleVenta }, newDetalle);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id)
        {
            return Ok();
        }

        // DELETE api/<DetalleVentaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var DetalleDelete = await Get(id);
            if (DetalleDelete == null)
            {
                return NotFound();
            }
            _dbContext.DetalleVentas.Remove(DetalleDelete.Value);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        private DetalleVenta MapDetalleObject(DetalleVentaDTO oferta)
        {
            var result = new DetalleVenta();
            result.Fecha = oferta.Fecha;
            return result;
        }
    }
}
