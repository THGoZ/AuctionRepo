using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Auction.Core.Entities
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }

        [Column("PrecioBase", TypeName = "decimal(18, 2)")]
        public decimal PrecioBase { get; set; }
        public byte[]? Imagen { get; set; }

        public int? IdSubasta { get; set; }

        [ForeignKey("IdSubasta")]
        public virtual Subasta? Subasta { get; set; }
        public int IdUsuario { get; set; }

        // Propiedad de navegación hacia Usuario
        [ForeignKey("IdUsuario")]
        public virtual Usuario? Usuario { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaSolicitud { get; set; }

        public bool EstadoDeSolicitud { get; set; } = false; //aprobado = true

        public virtual ICollection<Oferta>? Ofertas { get; set; }
    }
}