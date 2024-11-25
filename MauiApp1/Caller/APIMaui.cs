using Auction.Core.Entities;
using AuctionMobileApp.Caller.Interfases;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AuctionMobileApp.Caller
{
    public class APIMaui : IAPIMaui
    {
        private readonly HttpClient _httpClient;

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

        public async Task<List<ProductoWinner>?> GetWinners(int subastaId)
        {
            // Llama al endpoint que devuelve los ganadores de los productos en una subasta
            var winners = await _httpClient.GetFromJsonAsync<List<ProductoWinner>?>($"/api/Producto/winners/{subastaId}");

            // Comprueba si la lista no es nula y devuelve los ganadores
            return winners;
        }

        public async Task<List<ProductoAPI>?> GetProductsWithOfertas()
        {
            var productos = await _httpClient.GetFromJsonAsync<List<ProductoAPI>?>("/api/Producto");
            if (productos is not null)
            {
                productos = productos.Where(x => x.EstadoDeSolicitud == true).ToList();
                foreach (var producto in productos)
                {
                    producto.CantidadDeOfertas = await _httpClient.GetFromJsonAsync<int>($"/api/Producto/ofertas/{producto.IdProducto}");
                    var response = await _httpClient.GetStringAsync($"/api/Producto/sold/{producto.IdProducto}");
                    producto.Status = response;
                }
                return productos.Where(p => p.Status != "sold" || p.Status != "notsold").ToList();
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
                return filter.Where(x=> x.EstadoDeSolicitud == true).ToList();
            }
            else return null;
        }
        public async Task<List<ProductoAPI>?> GetOpenAuctionsProducts()
        {
            // Obtén todas las subastas
            var subastas = await _httpClient.GetFromJsonAsync<List<SubastaAPI>?>("/api/Subasta/Open");

            if (subastas is not null)
            {
                var subastasAbiertas = subastas;

                var todosLosProductos = new List<ProductoAPI>();

                // Obtén los productos para cada subasta abierta
                foreach (var subasta in subastasAbiertas)
                {
                    var productosDeSubasta = await GetProductsOfAuctionWithOferta(subasta.IdSubasta);
                    if (productosDeSubasta != null)
                    {
                        todosLosProductos.AddRange(productosDeSubasta);
                    }
                }

                return todosLosProductos;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Subasta
        public async Task<List<SubastaAPI>?> GetAuctions()
        {

            var subastas = await _httpClient.GetFromJsonAsync<List<SubastaAPI>?>("/api/Subasta");

            if (subastas is not null)
            {
                subastas = subastas.Where(s => s.FechaInicio <= DateTime.Now).ToList();
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
        public async Task<List<SubastaAPI>?> GetClosedSubastas()
        {
            // Llamada a la API que obtiene las subastas cerradas
            return await _httpClient.GetFromJsonAsync<List<SubastaAPI>?>("/api/Subasta/Closed");
        }
        #endregion
    }
}
