using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionDesktopProgram.Helper
{
    public class ProductoSolicitudDisplay
    {
        public int IdProducto {  get; set; }
        public string Nombre {  get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaDeSolicitud {  get; set; }
        public decimal PrecioBase { get; set; }
        public byte[] Imagen {  get; set; }
        public string Usuario { get; set; }
        public int? IdSubasta { get; set; }
    }
}
