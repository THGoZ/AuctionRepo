using System.ComponentModel.DataAnnotations;

namespace AuctionWebApp.Models.ViewModels
{
    public class ProductoViewModel
    {
        public int ProductoId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese un nombre")]
        public string? Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una descripcion")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese un precio valido")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio base debe ser mayor a cero")]
        public decimal PrecioBase { get; set; }
        public byte[]? Imagen { get; set; }

        public int? SubastaId { get; set; }
    }
}
