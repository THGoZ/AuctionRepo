using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionAPIC.Models.APIModels
{
    public class LoginDTO
    {
        public string Email { get; set; } = null!;
        public string Contrasena { get; set; } = null!;
    }
}
