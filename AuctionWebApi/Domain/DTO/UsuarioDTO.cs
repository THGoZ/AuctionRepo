using Auction.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionWebApi.Domain.DTO
{
    public class UsuarioDTO
    {

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public string? Direccion { get; set; }

        public string? Ciudad { get; set; }

        public string Email { get; set; }

        public string Contrasena { get; set; }
        [MaxLength(11)]
        public string? Cuil { get; set; }

    }
}
