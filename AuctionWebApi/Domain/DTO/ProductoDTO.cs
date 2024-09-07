using Auction.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionWebApi.Domain.DTO
{
    public class ProductoDTO
    {
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal PrecioBase { get; set; }
        public byte[]? Imagen { get; set; }
        public string? ImageExtension { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public bool EstadoDeSolicitud { get; set; } = false; //aprobado = true

    }
}
