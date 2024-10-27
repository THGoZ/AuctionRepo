using System.ComponentModel.DataAnnotations;

namespace AuctionBlazorWebApp.Models.ViewModels
{
    public class ProductoViewModel
    {
        public int ProductoId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese un nombre")]
        [MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
        public string? Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una descripcion")]
        [MinLength(6, ErrorMessage = "La descripcion debe tener por lo menos 6 caracteres")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese un precio valido")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio base debe ser mayor a cero")]
        public decimal PrecioBase { get; set; }
        [Required(ErrorMessage ="Ingrese una imagen")]
        public byte[]? Imagen { get; set; }
        public string? ImageExtension { get; set; }
        public DateTime FechaSolicitud { get; set; }

        public int? SubastaId { get; set; }
        public int IdUsuario { get; set; }
    }
}
