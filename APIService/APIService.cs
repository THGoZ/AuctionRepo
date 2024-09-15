using APIService.Models;
using Auction.Core.Entities;
using AuctionAPIC.Models.APIModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        public async Task<List<ProductoAPI>?> GetProductsOfUser(int id)
        {
            var UserProducts = await _httpClient.GetFromJsonAsync<List<ProductoAPI>?>($"/api/Producto/User/{id}");

            if (UserProducts is not null)
            {
                foreach (var producto in UserProducts)
                {
                    producto.CantidadDeOfertas = await _httpClient.GetFromJsonAsync<int>($"/api/Producto/ofertas/{producto.IdProducto}");
                    if (producto.CantidadDeOfertas > 0)
                    {
                        producto.OfertaMasAlta = await _httpClient.GetFromJsonAsync<decimal?>($"/api/Producto/bid/{producto.IdProducto}");
                    }
                    else
                    {
                        producto.OfertaMasAlta = 0;
                    }
                }
                return UserProducts;
            }
            else return null;
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

        public async Task<List<ProductoWinner>?> GetProductWinners(int SubastaId)
        {
            return await _httpClient.GetFromJsonAsync<List<ProductoWinner>?>($"/api/Producto/winners/{SubastaId}");

        }

        public async Task<ProductoAPI?> CheckOfertas(int id)
        {
            return await _httpClient.GetFromJsonAsync<ProductoAPI?>($"/api/Producto/{id}");
        }

        public async Task<int?> GetProductoCount()
        {
            return await _httpClient.GetFromJsonAsync<int?>("/api/Producto/cantidad");
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

        public async Task<List<SubastaAPI>?> GetIncomingAuctions()
        {
            var subastas = await _httpClient.GetFromJsonAsync<List<SubastaAPI>?>("/api/Subasta/Incoming");
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

        public async Task<List<SubastaAPI>?> GetClosedSubastas()
        {
            var subastas = await _httpClient.GetFromJsonAsync<List<SubastaAPI>?>("/api/Subasta");
            if (subastas is not null)
            {
                var newlist = subastas.Where(p => p.FechaCierre < DateTime.Now).ToList();
                foreach (var subasta in newlist)
                {
                    subasta.CantidadDeOfertas = await _httpClient.GetFromJsonAsync<int>($"/api/Subasta/Ofertas/{subasta.IdSubasta}");
                    subasta.CantidadProductos = await _httpClient.GetFromJsonAsync<int>($"/api/Subasta/cantidad/{subasta.IdSubasta}");
                }
                return newlist;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<SubastaAPI>?> GetOpenSubastas()
        {
            var subastas = await _httpClient.GetFromJsonAsync<List<SubastaAPI>?>("/api/Subasta/Open");
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

        public async Task<int> SubastaCount()
        {
            return await _httpClient.GetFromJsonAsync<int>("/api/Subasta/cantidad");
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
