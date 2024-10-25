using System.ComponentModel.DataAnnotations;

namespace AuctionBlazorWebApp.Models.ViewModels
{
    public class UpdateUserDataViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese un nombre")]
        public string? Nombre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese un Apellido")]
        public string? Apellido { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una direccion")]
        public string? Direccion { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una ciudad")]
        public string? Ciudad { get; set; }
        [Required]
        [Range(1, 99, ErrorMessage = "El valor es incorrecto!")]
        public int Cuil1 { get; set; }
        [Required]
        [Range(1, 99999999, ErrorMessage = "El valor es incorrecto!")]
        public int Cuil2 { get; set; }
        [Required]
        [Range(1, 9, ErrorMessage = "El valor es incorrecto!")]
        public int Cuil3 { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese su contraseña")]
        public string Contrasena { get; set; } = string.Empty;
    }
}
