using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Core.Entities
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("idUsuario")]
        public int IdUsuario { get; set; }

        [Column("nombre")]
        [MaxLength(50)]
        public string? Nombre { get; set; }

        [Column("apellido")]
        [MaxLength(50)]
        public string? Apellido { get; set; }

        [Column("direccion")]
        [MaxLength(50)]
        public string? Direccion { get; set; }
        [Column("cuil")]
        [MaxLength(14)]
        public string? Cuil { get; set; }

        [Column("ciudad")]
        [MaxLength(50)]
        public string? Ciudad { get; set; }

        [Column("email")]
        [Required, MaxLength(50)]
        public string Email { get; set; }

        [Column("contrasena")]
        [Required]
        public string Contrasena { get; set; }

        // Propiedad de navegación para representar la relación con Productos

        public byte[] Salt { get; set; }
        public virtual ICollection<Producto>? Productos { get; set; }

        public virtual ICollection<Oferta>? Ofertas { get; set; }

        public virtual ICollection<DetalleVenta>? DetalleVentas { get; set; }
    }
}
