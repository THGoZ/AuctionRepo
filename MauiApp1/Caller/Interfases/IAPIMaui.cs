using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Caller.Interfases
{
    public interface IAPIMaui
    {
        Task<List<SubastaAPI>?> GetAuctions();
        Task<List<ProductoAPI>?> GetProductsOfAuctionWithOferta(int SubastaId);

    }
}
