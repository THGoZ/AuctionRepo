using Auction.Core.Business.Interfaces;
using Auction.Core.Data;
using Auction.Core.Data.Interfaces;
using Auction.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auction.Core.Business
{
    public class ProductoBusiness : IProductoBusiness
    {
        private readonly IAuctionRepository _repository;

        public ProductoBusiness(IAuctionRepository auctionRepository)
        {
            _repository = auctionRepository;
        }

        public List<Producto> GetProductos()
        {
            return _repository.GetProductos();
        }

        public List<Producto> GetProductosSolicitados()
        {
            return _repository.GetProductosSolicitados();
        }
        public List<Producto> GetProductosSinOfertas()
        {
            return _repository.GetProductosSinOfertas();
        }

        public void ActualizarEstadoProducto(Producto productoSeleccionado)
        {
            _repository.ActualizarEstadoProducto(productoSeleccionado);
        }

        public List<ProductoWinner> GetProductoWinnersOfSubasta(int IdSubasta)
        {
            var productos = _repository.GetProductoWinnerOfSubasta(IdSubasta);

            return productos;
        }

        public void UpdateProducto(int id, bool estado)
        {
            try
            {
                var producto = _repository.GetProducto(id);
                producto.EstadoDeSolicitud = estado;
                _repository.ActualizarEstadoProducto(producto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el producto {ex.Message}");
            }
        }
        public List<Oferta> GetOfertasOfProducto(int id)
        {
            var ofertas = _repository.GetOfertasOfProducto(id);
            return ofertas;
        }
    }
}
