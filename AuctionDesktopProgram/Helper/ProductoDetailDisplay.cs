using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionDesktopProgram.Helper
{
    public class ProductoDetailDisplay
    {
        public int IdProducto {  get; set; }
        public string Nombre { get; set; }
        public decimal PrecioBase { get; set; }
        public decimal MaximaOferta {  get; set; }
        public int TotalDeOfertas { get; set; } = 0;
        public DateTime FechaDeSolicitud { get; set; }
        public string Descripcion {  get; set; }
        public byte[] Image {  get; set; }
    }
}
