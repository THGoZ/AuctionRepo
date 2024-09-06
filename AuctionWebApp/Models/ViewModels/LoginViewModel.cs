using System.ComponentModel.DataAnnotations;

namespace AuctionWebApp.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese un correo")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una contraseña")]
        public string Contrasena { get; set; }
    }
}
