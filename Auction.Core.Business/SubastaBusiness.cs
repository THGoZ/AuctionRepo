using Auction.Core.Business.Interfaces;
using Auction.Core.Data;
using Auction.Core.Data.Interfaces;
using Auction.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auction.Core.Business
{
    public class SubastaBusiness : ISubastaBusiness
    {
        private readonly IAuctionRepository _repository;

        public SubastaBusiness(IAuctionRepository auctionRepository)
        {
            _repository = auctionRepository;
        }

        public List<Subasta> GetAll()
        {
            return _repository.GetSubastas();
        }

    }
}
