using Auction.Core.Data.Interfaces;
using Auction.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Core.Data
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly AuctionDBContext _dbContext;

        public AuctionRepository(AuctionDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Producto> GetProductos()
        {
            var subastasConProductos = _dbContext.Subastas
                .Include(s => s.Productos) 
                .ToList();

          
            if (subastasConProductos == null || subastasConProductos.Count == 0)
            {
                throw new InvalidOperationException("No se encontraron subastas con productos en la base de datos.");
            }

            var productos = subastasConProductos.SelectMany(s => s.Productos).ToList();
       
            if (productos == null || productos.Count == 0)
            {
                throw new InvalidOperationException("No se encontraron productos en la base de datos.");
            }

            return productos;
        }

        public List<Subasta> GetSubastas()
        {
            return [.. _dbContext.Subastas];
        }

        public List<Oferta> GetOfertas()
        {
            // Obtener subastas, productos, ofertas y usuarios
            var ofertasPorSubasta = _dbContext.Subastas
                .Include(s => s.Productos)                // Incluir productos
                    .ThenInclude(p => p.Ofertas)          // Incluir ofertas de cada producto
                        .ThenInclude(o => o.Usuario)      // Incluir usuario de cada oferta
                .ToList()                                 // Convertir a lista
                .SelectMany(s => s.Productos)             // Iterar productos de cada subasta
                .SelectMany(p => p.Ofertas)               // Iterar ofertas de cada producto
                .Where(o => o.Usuario != null && o.Producto != null) // Verificar que no sean nulos
                .ToList();                                // Convertir el resultado final en una lista

            return ofertasPorSubasta;
        }

        public List<ProductoWinner> GetProductoWinners()
        {
            var productosConGanadores = _dbContext.Productos
           .Include(p => p.Ofertas)
           .ThenInclude(o => o.Usuario) // Para obtener la información del usuario
           .Where(p => p.Ofertas.Any()) // Solo productos con al menos una oferta
           .Select(p => new ProductoWinner
            {
            Nombre = p.Nombre,
            Descripcion = p.Descripcion,
            PrecioBase = p.PrecioBase,
            Imagen = p.Imagen,
            ImageExtension = p.ImageExtension,
            HasGanador = p.Ofertas.Any(), // Si tiene ofertas, tiene ganador
            NombreGanador = p.Ofertas.OrderByDescending(o => o.Monto).FirstOrDefault().Usuario.Nombre, // Tomar el nombre del usuario de la mejor oferta
            ApellidoGanador = p.Ofertas.OrderByDescending(o => o.Monto).FirstOrDefault().Usuario.Apellido,
            Monto = p.Ofertas.OrderByDescending(o => o.Monto).FirstOrDefault().Monto,
            Fecha = p.Ofertas.OrderByDescending(o => o.Monto).FirstOrDefault().Fecha,
            TotalDeOfertas = p.Ofertas.Count
            })
        .ToList();

            return productosConGanadores;
        }



    }
}
