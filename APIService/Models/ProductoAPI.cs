using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIService.Models
{
    public class ProductoAPI
    {
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioBase { get; set; }
        public byte[]? Imagen { get; set; }
        public string? ImageExtension { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public bool? EstadoDeSolicitud { get; set; }//null = pendiente/ false = rechazado / true = aprovado

        public int? IdSubasta { get; set; }

        public int IdUsuario { get; set; }
        public int CantidadDeOfertas { get; set; }

        public decimal OfertaMasAlta { get; set; } = 0;

        public string Status { get; set; } = string.Empty;
    }
}
