using Auction.Core.Entities;

namespace AuctionWebApi.Services.Interfaces
{
    public interface ISubastaService
    {
        Task<IEnumerable<Subasta>> GetSubastasToCloseAsync(DateTime currentTime);
        Task<IEnumerable<Subasta>> GetSubastasToOpenAsync(DateTime currentTime);
        Task CloseSubastaAsync(Subasta subasta);
        Task OpenSubastaAsync(Subasta subasta);

        Task GenerateFacturas(List<Producto>? productos, DateTime fecha);
    }
}
