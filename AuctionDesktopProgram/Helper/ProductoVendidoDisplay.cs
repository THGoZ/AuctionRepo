using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionDesktopProgram.Helper
{
    public class ProductoVendidoDisplay
    {
        public string NombreProducto {  get; set; }
        public string NombreGanador { get; set; }
        public string ApellidoGanador { get; set; }
        public decimal PrecioBase {  get; set; }
        public decimal? MontoFinal { get; set; }
        public decimal? GananciaVendedor { get; set; }
        public decimal? GananciaEmpresa {  get; set; }
    }
}
