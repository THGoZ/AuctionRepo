using Auction.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Auction
{
    public class SubastaDTO
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaCierre { get; set; }
        public string[] ModoEntrega { get; set; } = null!;
        public string[] FormaDePago { get; set; } = null!;
        public bool? Estado { get; set; }//Activa = true /-Finalizada = false, null = proxima
        public string Descripcion { get; set; } = null!;
    }
}
