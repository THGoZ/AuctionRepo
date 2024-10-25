using Auction.Core.Data;
using Auction.Core.Entities;
using AuctionAPIC.Models.APIModels;
using AuctionWebApi.Domain.DTO;
using AuctionWebApi.Services;
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
            var existingUsuario = await _dbContext.Usuarios.FirstOrDefaultAsync(u => u.Email == usuarioDto.Email);

            if(existingUsuario != null)
            {
                return BadRequest(new { message = "El email ya existe!" });
            }

            byte[] salt = null;

            var usuario = new Usuario
            {
                Nombre = usuarioDto.Nombre,
                Apellido = usuarioDto.Apellido,
                Direccion = usuarioDto.Direccion,
                Ciudad = usuarioDto.Ciudad,
                Email = usuarioDto.Email,
                Contrasena = PasswordHashing.HashPasword(usuarioDto.Contrasena, out salt),
                Salt = salt,
                Cuil = usuarioDto.Cuil
            };

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
                byte[] salt = null;
                usuario.Nombre = editedUser.Nombre;
                usuario.Apellido = editedUser.Apellido;
                usuario.Direccion = editedUser.Direccion;
                usuario.Email = editedUser.Email;
                usuario.Ciudad = editedUser.Ciudad;
                usuario.Contrasena = PasswordHashing.HashPasword(editedUser.Contrasena, out salt);
                usuario.Salt = salt;
                _dbContext.Usuarios.Update(usuario);
                await _dbContext.SaveChangesAsync();
                return Ok();
            }
        }

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

        #region Cosas de cuentas blazor
        [HttpPut]
        [Route("login")]
        public async Task<ActionResult<SesionDTO>> Login([FromBody] LoginDTO login)
        {
            SesionDTO session = new SesionDTO();
            var exists = await _dbContext.Usuarios.AnyAsync(x => x.Email == login.Email);
            if (exists)
            {
                var user = await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Email == login.Email);
                if (PasswordHashing.VerifyPassword(login.Contrasena, user.Contrasena, user.Salt))
                {
                    session.IdUsuario = user.IdUsuario;
                    session.Apellido = user.Apellido;
                    session.Nombre = user.Nombre;
                    session.Wrongpassoword = false;
                    return Ok(session);
                }
                else
                {
                    return Ok(session);
                }
            }
            else
            {
                return NotFound(session);
            }
        }
        [HttpPut]
        [Route("changepassword")]
        public async Task<ActionResult<string>> ChangePassWord(UserPassChangeDTO user)
        {
            if (!ModelState.IsValid)
                return BadRequest("Datos invalidos.");

            var oldUser = await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Email == user.Email);

            if (oldUser == null)
            {
                return NotFound("Usuario no encontrado");
            }

            if (!PasswordHashing.VerifyPassword(user.Contrasena, oldUser.Contrasena, oldUser.Salt))
            {
                return Unauthorized("Contraseña incorrecta!");
            }

            try
            {
                byte[] salt;
                oldUser.Contrasena = PasswordHashing.HashPasword(user.NewPassword, out salt);
                oldUser.Salt = salt;

                _dbContext.Usuarios.Update(oldUser);
                await _dbContext.SaveChangesAsync();

                return Ok("Contraseña actualizada correctamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar la contraseña.{ex.Message}");
            }
        }

        [HttpPut]
        [Route("updateuser")]
        public async Task<ActionResult<string>> UpdateUser(UsuarioDTO user)
        {
            if (!ModelState.IsValid)
                return BadRequest("Datos invalidos.");

            var oldUser = await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Email == user.Email);

            if (oldUser == null)
            {
                return NotFound("Usuario no encontrado");
            }

            if (!PasswordHashing.VerifyPassword(user.Contrasena, oldUser.Contrasena, oldUser.Salt))
            {
                return Unauthorized("Contraseña incorrecta!");
            }

            try
            {
                oldUser.Nombre = user.Nombre;
                oldUser.Apellido = user.Apellido;
                oldUser.Direccion = user.Direccion;
                oldUser.Ciudad = user.Ciudad;
                oldUser.Cuil = user.Cuil;

                _dbContext.Usuarios.Update(oldUser);
                await _dbContext.SaveChangesAsync();

                return Ok("Datos de usuario actualizados correctamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar usuario.{ex.Message}");
            }
        }

        #endregion
    }
}
