using Auction.Core.Data;
using Auction.Core.Entities;
using AuctionWebApi.Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertaController : ControllerBase
    {
        private readonly AuctionDBContext _dbContext;
        public OfertaController(AuctionDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Oferta>> GetAll()
        {

            return _dbContext.Ofertas;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Oferta?>> GetById(int id)
        {
            var oferta = await _dbContext.Ofertas
                .SingleOrDefaultAsync(x => x.IdOferta == id);

            if (oferta == null)
            {
                return NotFound();
            }

            return oferta;
        }

        [HttpPost("{IdUser}/{IdProducto}")]
        public async Task<ActionResult> CreateOferta(int IdUser, int IdProducto, OfertaDTO oferta)
        {
            var newOferta = MapOfertaObject(oferta);
            newOferta.IdProducto = IdProducto;
            newOferta.IdUsuario = IdUser;
            await _dbContext.Ofertas.AddAsync(newOferta);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = newOferta.IdOferta }, newOferta);
        }

        [HttpPut("{id}/{IdProducto}/{IdUser}")]
        public async Task<ActionResult> UpdateOferta(OfertaDTO oferta, int id, int IdProducto, int IdUser)
        {
            var newOferta = MapOfertaObject(oferta);
            newOferta.IdOferta = id;
            newOferta.IdProducto = IdProducto;
            newOferta.IdUsuario = IdUser;
            _dbContext.Ofertas.Update(newOferta);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteOferta(int id)
        {
            var OfertaDelete = await GetById(id);
            if (OfertaDelete.Value is null)
            {
                return NotFound();
            }
            _dbContext.Remove(OfertaDelete.Value);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{id:int}/{IdUser:int}")]
        public async Task<bool> CheckUserOfertas(int id, int IdUser)
        {
            var result = await _dbContext.Ofertas.Where(x => x.IdProducto == id && x.IdUsuario == IdUser).AnyAsync();

            return result;
        }

        private Oferta MapOfertaObject(OfertaDTO oferta)
        {
            var result = new Oferta();
            result.Monto = oferta.Monto;
            result.Fecha = oferta.Fecha;
            return result;
        }
    }
}
