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
        public List<Producto> GetProductosSinOfertas();

        public void UpdateSubasta (Subasta subasta);
        public List<Producto> GetProductosSolicitados();
        void AddSubasta(Subasta subasta); 
        void SaveChanges(); 
        public void ActualizarEstadoProducto(Producto productoSeleccionado);

        public Subasta GetSubastaById(int id);
        public List<Subasta> GetSuccessfulSubastas();
        public List<ProductoWinner> GetProductoWinnerOfSubasta(int IdSubasta);
        public Producto GetProducto(int id);
        public List<Oferta> GetOfertasOfProducto(int id);
    }
}
