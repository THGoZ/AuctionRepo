using APIService.Models;
using AuctionAPIC.Models.APIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace APIService
{
    public class APIService
    {
        private readonly HttpClient _httpClient;

        public APIService(APICLientOptions APICLientOptions)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new System.Uri(APICLientOptions.ApiBaseAddress);
        }
        #region Producto
        public async Task<List<ProductoAPI>?> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<List<ProductoAPI>?>("/api/Producto");
        }

        public async Task<List<ProductoAPI>?> GetProductsOfAuction(int SubastaId)
        {
            var nofilter = await _httpClient.GetFromJsonAsync<List<ProductoAPI>?>("/api/Producto");
            return nofilter.Where(x => x.IdSubasta == SubastaId).ToList();

        }

        public async Task<ProductoAPI?> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<ProductoAPI?>($"/api/Producto/{id}");
        }

        public async Task SaveProduct(ProductoAPI product, int UserId, int SubastaId)
        {
            await _httpClient.PostAsJsonAsync($"/api/Producto/{UserId}/{SubastaId}", product);
        }

        public async Task UpdateProducto(ProductoAPI producto, int id, int subastaId)
        {
            await _httpClient.PutAsJsonAsync($"/api/Producto/{id}/{subastaId}", producto);
        }

        public async Task DeleteProducto(int id)
        {
            await _httpClient.DeleteAsync($"/api/Producto/{id}");
        }
        #endregion

        #region Usuario
        public async Task<SesionDTO?> ValidateUser(LoginDTO user)
        {
            var loginresponse = await _httpClient.PutAsJsonAsync("/api/Usuario/login", user);
            if (loginresponse.IsSuccessStatusCode)
            {
                return await loginresponse.Content.ReadFromJsonAsync<SesionDTO>();
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
            return await _httpClient.GetFromJsonAsync<List<SubastaAPI>?>("/api/Subasta");
        }
        #endregion
    }
}
