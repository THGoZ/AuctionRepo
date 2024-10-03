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


    }
}
