using Auction.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Core.Business.Interfaces
{
    public interface IProductoBusiness
    {
        public void ActualizarEstadoProducto(Producto productoSeleccionado);
        public List<Producto> GetProductos();

        public List<Producto> GetProductosSolicitados();

    }
}
