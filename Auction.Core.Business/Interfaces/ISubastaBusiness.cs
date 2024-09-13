using Auction.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Core.Business.Interfaces
{
    public interface ISubastaBusiness
    {
        public List<Subasta> GetAll();
    }
}
