using Microsoft.EntityFrameworkCore;
using Auction.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Core.Data
{
    public class AuctionDBContext : DbContext
    {
        public AuctionDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Informe> Informes { get; set; }
        public DbSet<Oferta> Ofertas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Subasta> Subastas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
