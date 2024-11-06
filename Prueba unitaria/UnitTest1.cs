using Auction.Core.Data;
using Auction.Core.Entities;
using AuctionWebApi.Controllers;
using Microsoft.EntityFrameworkCore;
using Moq;
using NSubstitute;

namespace Prueba_unitaria
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            // Arrange: Use an In-Memory Database
            var options = new DbContextOptionsBuilder<AuctionDBContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new AuctionDBContext(options))
            {
                var creador = new CreadorSubasta(context);

                var subasta = new Subasta
                {
                    FechaInicio = DateTime.Now, 
                    FechaCierre = DateTime.Now.AddDays(7), 
                    FormaDePago = new string[] { "Tarjeta de credito", "PayPal" }, 
                    ModoEntrega = new string[] { "En local", "Correo" }, 
                    Descripcion = "Subasta de cosas exclusivas", 
                    Estado = true, 
                    Productos = new List<Producto>() 
                };

                var result = creador.CrearSubastas(subasta);

                Assert.NotNull(result);
                Assert.Equal(subasta.FechaInicio, result.FechaInicio);
                Assert.Equal(subasta.FechaCierre, result.FechaCierre);
                Assert.Equal(subasta.FormaDePago, result.FormaDePago);
                Assert.Equal(subasta.ModoEntrega, result.ModoEntrega);
                Assert.Equal(subasta.Descripcion, result.Descripcion);
                Assert.Equal(subasta.Estado, result.Estado);
                Assert.NotNull(result.Productos);
            }
        }


        private static DbSet<T> FakeDbSet<T>(List<T> data) where T : class
        {
            var queryableData = data.AsQueryable();
            var fakeDbSet = Substitute.For<DbSet<T>, IQueryable<T>>();

            ((IQueryable<T>)fakeDbSet).Provider.Returns(queryableData.Provider);
            ((IQueryable<T>)fakeDbSet).Expression.Returns(queryableData.Expression);
            ((IQueryable<T>)fakeDbSet).ElementType.Returns(queryableData.ElementType);
            ((IQueryable<T>)fakeDbSet).GetEnumerator().Returns(queryableData.GetEnumerator());

            return fakeDbSet;
        }
    }
}