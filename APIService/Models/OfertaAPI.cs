using Auction.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIService.Models
{
    public class OfertaAPI
    {
        public int IdOferta { get; set; }

        public int? IdUsuario { get; set; }

        public int? IdProducto { get; set; }

        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
