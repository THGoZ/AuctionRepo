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
                .Include(s => s.Productos) // Cargar productos relacionados
                .ToList();

            // Verificar si hay subastas con productos
            if (subastasConProductos == null || subastasConProductos.Count == 0)
            {
                throw new InvalidOperationException("No se encontraron subastas con productos en la base de datos.");
            }

            // Extraer todos los productos de las subastas
            var productos = subastasConProductos.SelectMany(s => s.Productos).ToList();

            // Verificar si hay productos
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



    }
}
