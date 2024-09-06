using Auction.Core.Data;
using Auction.Core.Entities;
using AuctionAPIC.Models.APIModels;
using AuctionWebApi.Domain.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AuctionDBContext _dbContext;

        public UsuarioController(AuctionDBContext demoDbContext) => _dbContext = demoDbContext;

        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            return _dbContext.Usuarios;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario?>> GetById(int id)
        {
            return await _dbContext.Usuarios.Include(s => s.Productos) // A reemplazar por lazyloading
                .SingleOrDefaultAsync(x => x.IdUsuario == id);
        }

        [HttpPost]
        public async Task<ActionResult> Create(UsuarioDTO usuarioDto)
        {
            var usuario = new Usuario
            {
                Nombre = usuarioDto.Nombre,
                Apellido = usuarioDto.Apellido,
                Direccion = usuarioDto.Direccion,
                Ciudad = usuarioDto.Ciudad,
                Email = usuarioDto.Email,
                Contrasena = usuarioDto.Contrasena
            };

            if (!ModelState.IsValid) //Valida que sean correctas las entradas
            {
                return BadRequest(ModelState);
            }

            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = usuario.IdUsuario }, usuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UsuarioDTO editedUser)
        {
            var usuario = await _dbContext.Usuarios.Where(x => x.IdUsuario == id).SingleOrDefaultAsync();
            if (usuario == null)
            {
                return NotFound();
            }
            else
            {
                usuario.Nombre = editedUser.Nombre;
                usuario.Apellido = editedUser.Apellido;
                usuario.Direccion = editedUser.Direccion;
                usuario.Email = editedUser.Email;
                usuario.Ciudad = editedUser.Ciudad;
                usuario.Contrasena = editedUser.Contrasena;
                _dbContext.Usuarios.Update(usuario);
                await _dbContext.SaveChangesAsync();
                return Ok();
            }
        }
        //if (id != usuario.IdUsuario)
        //{
        //    return BadRequest("El ID del usuario no coincide con el ID de la URL.");
        //}

        //if (!ModelState.IsValid)
        //{
        //    return BadRequest(ModelState);
        //}

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var usuarioGetByYdResult = await GetById(id);
            if (usuarioGetByYdResult.Value is null)
                return NotFound();

            _dbContext.Remove(usuarioGetByYdResult.Value);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        #region Cosas de login blazor
        [HttpPut]
        [Route("login")]
        public async Task<SesionDTO> Login([FromBody] LoginDTO login)
        {
            SesionDTO session = new SesionDTO();
            var exists = await _dbContext.Usuarios.AnyAsync(x => x.Email == login.Email);
            if (exists)
            {
                var user = await _dbContext.Usuarios.Where(x => x.Email == login.Email).SingleOrDefaultAsync();
                if (user.Contrasena == login.Contrasena)
                {
                    session.IdUsuario = user.IdUsuario;
                    session.Apellido = user.Apellido;
                    session.Nombre = user.Nombre;
                    session.Wrongpassoword = false;
                    return session;
                }
                else
                {
                    return session;
                }
            }
            else
            {
                return session;
            }
        }
        #endregion
    }
}
