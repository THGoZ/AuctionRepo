using System.ComponentModel.DataAnnotations;

namespace AuctionBlazorWebApp.Models.ViewModels
{
    public class PasswordChangeViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una contraseña")]
        public string contrasena { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una nueva contraseña")]
        public string newpassword { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirme la nueva contraseña")]
        [Compare("newpassword", ErrorMessage = "Las contraseñas no coinciden")]
        public string confirmpassword { get; set; }
    }
}
