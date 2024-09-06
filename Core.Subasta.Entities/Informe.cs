using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Core.Entities
{
    public class Informe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdInforme { get; set; }
        [Column("ganaciaVend", TypeName = "decimal(18, 2)")]
        public decimal ganaciaVend { get; set; }
        [Column("gananciaEmpr", TypeName = "decimal(18, 2)")]
        public decimal gananciaEmpr { get; set; }
        [ForeignKey("Subasta")]
        public int IdSubasta { get; set; }
        public virtual Subasta Subasta { get; set; }
    }
}
