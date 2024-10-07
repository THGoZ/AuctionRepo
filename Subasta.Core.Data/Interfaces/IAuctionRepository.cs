using Auction.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Core.Data.Interfaces
{
    public interface IAuctionRepository
    {
        public List<Subasta> GetSubastas();

        public List <Producto> GetProductos();

        public List <Oferta> GetOfertas();

        public List <ProductoWinner> GetProductoWinners();
        public List<Producto> GetProductosSolicitados();
        public void ActualizarEstadoProducto(Producto productoSeleccionado);
    }
}
