using Auction.Core.Entities;

namespace AuctionWebApi.Domain.DTO
{
    public class PaginatedProducts
    {
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public List<Producto> Items { get; set; } = new List<Producto>();
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
    }
}
