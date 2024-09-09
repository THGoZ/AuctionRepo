using APIService.Models;
using Auction.Core.Entities;
using AuctionAPIC.Models.APIModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<List<ProductoAPI>?> GetProductsOfAuction(int SubastaId)
        {
            var nofilter = await _httpClient.GetFromJsonAsync<List<ProductoAPI>?>("/api/Producto");
            return nofilter.Where(x => x.IdSubasta == SubastaId).ToList();

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

        public async Task<ProductoAPI?> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<ProductoAPI?>($"/api/Producto/{id}");
        }

        public async Task<ProductoAPI?> CheckOfertas(int id)
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

        public async Task CreateUsuario(UsuarioAPI user)
        {
            await _httpClient.PostAsJsonAsync($"/api/Usuario/", user);
        }
        #endregion

        #region Subasta
        public async Task<List<SubastaAPI>?> GetAuctions()
        {
            var subastas = await _httpClient.GetFromJsonAsync<List<SubastaAPI>?>("/api/Subasta");
            if(subastas is not null)
            {
                foreach (var subasta in subastas)
                {
                    subasta.CantidadDeOfertas = await _httpClient.GetFromJsonAsync<int>($"/api/Subasta/Ofertas/{subasta.IdSubasta}");
                }
                return subastas;
            }
            else
            {
                return null;
            }
            
        }
        #endregion

        #region Oferta

        public async Task AddOferta(OfertaAPI oferta, int UserId, int IdProducto)
        {
            await _httpClient.PostAsJsonAsync($"/api/Oferta/{UserId}/{IdProducto}", oferta);
        }

        public async Task<bool> CheckIfOferta(int IdProducto, int UserId)
        {
            return await _httpClient.GetFromJsonAsync<bool>($"/api/Oferta/{IdProducto}/{UserId}");

        }
        #endregion
    }
}
