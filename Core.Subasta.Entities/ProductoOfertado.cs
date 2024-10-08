using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Core.Entities
{
    public class ProductoOfertado
    {
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal PrecioBase { get; set; }
        public byte[]? Imagen { get; set; }
        public string? ImageExtension { get; set; }
        public bool? IsGanador { get; set; }
        [Column("Monto", TypeName = "decimal(18, 2)")]
        public decimal? Monto { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Fecha { get; set; }
        public int TotalDeOfertas { get; set; } = 0;
        public int? IdSubasta { get; set; }

        public int IdUsuario { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
