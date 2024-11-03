using Auction.Core.Business.Interfaces;
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
        public List<Oferta> GetOfertas()
        {
            return _repository.GetOfertas();
        }
        public List<ProductoWinner> GetProductoWinners()
        {
            return _repository.GetProductoWinners();
        }

        

        public void EditarSubasta(Subasta subasta)
        {
            _repository.UpdateSubasta(subasta);
        }

        public void CrearSubasta(Subasta subasta)
        {
            _repository.AddSubasta(subasta);
            _repository.SaveChanges(); 
        }

        public Subasta GetById(int id)
        {
            if (id <= 0)
                throw new Exception("El Id debe ser un numero positivo");
            return _repository.GetSubastaById(id);
        }

        public List<Subasta> GetSuccessful()
        {
            return _repository.GetSuccessfulSubastas();
        }

    }
}
