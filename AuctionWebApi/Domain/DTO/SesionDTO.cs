using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionAPIC.Models.APIModels
{
    public class SesionDTO
    {
        public int IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public bool Wrongpassoword { get; set; } = true;
    }
}
