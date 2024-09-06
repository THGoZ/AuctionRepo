using System.ComponentModel.DataAnnotations;

namespace AuctionBlazorWebApp.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese un correo")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una contraseña")]
        public string Contrasena { get; set; }
    }
}
