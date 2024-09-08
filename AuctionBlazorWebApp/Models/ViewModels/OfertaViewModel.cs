using System.ComponentModel.DataAnnotations;

namespace AuctionBlazorWebApp.Models.ViewModels
{
    public class OfertaViewModel
    {
        public int IdOferta { get; set; }

        public int? IdUsuario { get; set; }

        public int? IdProducto { get; set; }

        [Required(ErrorMessage = "Ingrese un precio valido")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio base debe ser mayor a cero")]
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
