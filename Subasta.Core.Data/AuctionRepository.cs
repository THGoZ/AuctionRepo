using Auction.Core.Data.Interfaces;
using Auction.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Core.Data
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly AuctionDBContext _dbContext;

        public AuctionRepository(AuctionDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Subasta> GetSubastas()
        {
            return [.. _dbContext.Subastas];
        }
    }
}
