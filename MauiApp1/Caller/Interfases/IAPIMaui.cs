using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionMobileApp.Caller.Interfases
{
    public interface IAPIMaui
    {
        Task<List<SubastaAPI>?> GetAuctions();
        Task<List<ProductoAPI>?> GetProductsOfAuctionWithOferta(int SubastaId);
        Task<List<ProductoAPI>?> GetProducts();
        Task<List<ProductoAPI>?> GetProductsWithOfertas();

        Task<PaginatedProductsAPI?> GetPaginatedProducts(int page = 1, int pagesize = 5);

        Task<List<ProductoWinner>?> GetWinners(int subastaId);
        Task<List<SubastaAPI>?> GetClosedSubastas();
    }
}
