using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auction.Core.Entities
{
    public class Subasta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSubasta { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaInicio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaCierre { get; set; }
        public string[] ModoEntrega { get; set; } = null!;
        public string[] FormaDePago { get; set; } = null!;
        public bool? Estado { get; set; }//Activa = true /-Finalizada = false, null = proxima
        public string Descripcion { get; set; } = null!;

        // Relaciones
        public virtual ICollection<Producto>? Productos { get; set; }
        public virtual Informe? Informe { get; set; }
    }
}
