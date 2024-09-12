using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Auction.Core.Entities
{
    public class ProductoWinner
    {
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal PrecioBase { get; set; }
        public byte[]? Imagen { get; set; }
        public string? ImageExtension { get; set; }
        public bool HasGanador { get; set; }
        public string? NombreGanador { get; set; }
        public string? ApellidoGanador { get; set; }
        [Column("Monto", TypeName = "decimal(18, 2)")]
        public decimal? Monto { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Fecha { get; set; }//no se si hay necesidad de poner esto
        public int TotalDeOfertas { get; set; } = 0;
    }
}
