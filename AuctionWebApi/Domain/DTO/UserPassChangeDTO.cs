namespace AuctionWebApi.Domain.DTO
{
    public class UserPassChangeDTO
    {
        public string Email { get; set; } = null!;
        public string Contrasena { get; set; } = null!;
        public string NewPassword { get; set; } = null!;
    }
}
