using APIService.Models;

namespace AuctionBlazorWebApp.Models.Helper
{
    public class EditProductData
    {
        public ProductoAPI? Producto { get; set; }
        public int Id { get; set; }
        public int SubastaId { get; set; }
    }
}
