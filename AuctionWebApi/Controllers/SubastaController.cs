using Auction.Core.Data;
using Auction.Core.Entities;
using Core.Auction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubastaController : ControllerBase
    {
        private readonly AuctionDBContext _dbContext;

        public SubastaController(AuctionDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Subasta>> Get()
        {
            return _dbContext.Subastas;
        }

        [HttpGet("Open/")]
        public ActionResult<IEnumerable<Subasta>> GetOpenSubastas() {
            return _dbContext.Subastas.Where(p => p.FechaCierre > DateTime.Now && p.FechaInicio <= DateTime.Now).ToList();
        }

        [HttpGet("Closed/")]
        public ActionResult<IEnumerable<Subasta>> GetClosedSubastas()
        {
            return _dbContext.Subastas.Where(p => p.FechaCierre < DateTime.Now).ToList();
        }

        [HttpGet("Incoming/")]
        public ActionResult<IEnumerable<Subasta>> GetInitiatedSubastas()
        {
            return _dbContext.Subastas.Where(p => p.FechaInicio > DateTime.Now).ToList();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Subasta?>> GetById(int id)
        {
            var subasta = await _dbContext.Subastas
                .SingleOrDefaultAsync(x => x.IdSubasta == id);

            if (subasta == null)
            {
                return NotFound();
            }

            return subasta;
        }

        [HttpGet("cantidad/")]
        public async Task<ActionResult<int?>> GetCantidad()
        {
            var subasta = await _dbContext.Subastas.AsNoTracking().CountAsync();

            if (subasta == null)
            {
                return NotFound();
            }
            else
            {
                return subasta;
            }
        }

        [HttpGet("cantidad/{id:int}")]
        public async Task<ActionResult<int?>> GetCantidadProductos(int id)
        {
            var subasta = await _dbContext.Subastas.Where(s => s.IdSubasta == id && s.Productos.Where(p=> p.EstadoDeSolicitud == true).Any()).SelectMany(p => p.Productos.Where(p=> p.EstadoDeSolicitud==true)).CountAsync();

            if (subasta == null)
            {
                return NotFound();
            }
            else
            {
                return subasta;
            }
        }

        [HttpGet("formaspagos/{id:int}")]
        public async Task<ActionResult<string[]?>> GetFormasDePago(int id)
        {
            var subasta = await _dbContext.Subastas.Where(s => s.IdSubasta == id).Select(s => s.FormaDePago).FirstOrDefaultAsync();

            if (subasta == null)
            {
                return NotFound();
            }
            else
            {
                return subasta;
            }
        }

        [HttpGet("ofertas/{id:int}")]
        public async Task<int> GetOfertasSubasta(int id)
        {
            var hasproducto = await _dbContext.Subastas.Where(s => s.IdSubasta == id).Select(subasta => subasta.Productos).AnyAsync();
            if (hasproducto)
            {
                bool hasoferta = await _dbContext.Subastas.Where(s => s.IdSubasta == id).AnyAsync(subasta => subasta.Productos.Any(p => p.Ofertas.Any()));

                if (hasoferta)
                {
                    var cantidad = await _dbContext.Subastas.Where(s => s.IdSubasta == id).SelectMany(p => p.Productos.SelectMany(p => p.Ofertas)).CountAsync();
                    return cantidad;
                }
                else return 0;
            }
            else return 0;
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateAuction(SubastaDTO subasta, int id)
        {
            var newSubasta = MapSubastaObject(subasta);
            newSubasta.IdSubasta = id;
            _dbContext.Subastas.Update(newSubasta);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> CreateAuction(SubastaDTO subasta)
        {
            var newSubasta = MapSubastaObject(subasta);
            await _dbContext.Subastas.AddAsync(newSubasta);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = newSubasta.IdSubasta }, newSubasta);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAuction(int id)
        {
            var AuctiontoDelete = await GetById(id);
            if (AuctiontoDelete.Value is null)
            {
                return NotFound();
            }
            _dbContext.Remove(AuctiontoDelete.Value);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("State/{id:int}")]
        public async Task<bool> CheckIfSubastaOpen(int id)
        {
            var result = await _dbContext.Subastas.Where(x => x.IdSubasta == id && x.FechaInicio <= DateTime.Now).AnyAsync();

            return result;
        }


        private Subasta MapSubastaObject(SubastaDTO subasta)//a reemplazar por mapeador 
        {
            var result = new Subasta();
            result.FechaInicio = subasta.FechaInicio;
            result.FechaCierre = subasta.FechaCierre;
            result.FormaDePago = subasta.FormaDePago;
            result.ModoEntrega = subasta.ModoEntrega;
            result.Descripcion = subasta.Descripcion;
            result.Productos = new List<Producto>();
            return result;
        }
    }
}
