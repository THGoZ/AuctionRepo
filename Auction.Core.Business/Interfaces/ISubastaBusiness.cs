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

        public List <Oferta> GetOfertas();

        public List<ProductoWinner> GetProductoWinners();

        public void EditarSubasta(Subasta subasta);

        public void CrearSubasta(Subasta subasta);

        public Subasta GetById(int id);
        public List<Subasta> GetSuccessful();
    }
}
