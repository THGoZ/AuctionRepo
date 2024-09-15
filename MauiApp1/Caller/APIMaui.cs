using AuctionMobileApp.Caller.Interfases;
using System.Net.Http.Json;
using System.Text.Json;

namespace AuctionMobileApp.Caller
{
    public class APIMaui : IAPIMaui
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _serializerOptions;

        public APIMaui(MAUIClientOptions APICLientOptions)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new System.Uri(APICLientOptions.ApiBaseAddress);
        }
        #region Producto
        public async Task<List<ProductoAPI>?> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<List<ProductoAPI>?>("/api/Producto");
        }

        public async Task<List<ProductoAPI>?> GetProductsWithOfertas()
        {
            var productos = await _httpClient.GetFromJsonAsync<List<ProductoAPI>?>("/api/Producto");
            if (productos is not null)
            {
                foreach (var producto in productos)
                {
                    producto.CantidadDeOfertas = await _httpClient.GetFromJsonAsync<int>($"/api/Producto/ofertas/{producto.IdProducto}");
                }
                return productos;
            }
            else return null;
        }

        public async Task<List<ProductoAPI>?> GetProductsOfAuctionWithOferta(int SubastaId)
        {
            var nofilter = await _httpClient.GetFromJsonAsync<List<ProductoAPI>?>("/api/Producto");

            if (nofilter is not null)
            {
                var filter = nofilter.Where(x => x.IdSubasta == SubastaId).ToList();
                foreach (var producto in filter)
                {
                    producto.CantidadDeOfertas = await _httpClient.GetFromJsonAsync<int>($"/api/Producto/ofertas/{producto.IdProducto}");
                }
                return filter;
            }
            else return null;
        }
        #endregion

        #region Subasta
        public async Task<List<SubastaAPI>?> GetAuctions()
        {

            var subastas = await _httpClient.GetFromJsonAsync<List<SubastaAPI>?>("/api/Subasta");

            if (subastas is not null)
            {
                foreach (var subasta in subastas)
                {
                    subasta.CantidadDeOfertas = await _httpClient.GetFromJsonAsync<int>($"/api/Subasta/Ofertas/{subasta.IdSubasta}");
                    subasta.CantidadProductos = await _httpClient.GetFromJsonAsync<int>($"/api/Subasta/cantidad/{subasta.IdSubasta}");
                }
                return subastas;
            }
            else
            {
                return null;
            }

        }
        #endregion
    }
}
