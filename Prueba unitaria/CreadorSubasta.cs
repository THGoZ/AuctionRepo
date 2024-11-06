using Auction.Core.Data;
using Auction.Core.Data.Interfaces;
using Auction.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_unitaria
{
    public class CreadorSubasta
    {
        private readonly AuctionDBContext _dbContext;

        public CreadorSubasta(AuctionDBContext repository)
        {
            _dbContext = repository;
        }

        public Subasta CrearSubastas(Subasta subasta)
        {
            try
            {
                _dbContext.Subastas.Add(subasta);
                _dbContext.SaveChanges();
                return subasta;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
