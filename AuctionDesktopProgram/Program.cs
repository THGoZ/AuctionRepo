using Auction.Core.Business;
using Auction.Core.Business.Interfaces;
using Auction.Core.Data;
using Auction.Core.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AuctionDesktopProgram
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                // Inicializa MainPage en lugar de FormHome
                var mainPage = serviceProvider.GetRequiredService<Mainpage>();
                Application.Run(mainPage);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            var connectionString = Properties.Settings.Default.ConnectionString;

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            services.AddScoped<AuctionDBContext>(x =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<AuctionDBContext>();
                optionsBuilder.UseSqlServer(connectionString);
                return new AuctionDBContext(optionsBuilder.Options);
            })
            .AddScoped<IAuctionRepository, AuctionRepository>()
            .AddScoped<ISubastaBusiness, SubastaBusiness>()
            .AddScoped<IProductoBusiness, ProductoBusiness>()
            .AddTransient<Mainpage>()
            .AddTransient<FormProductos>()
            .AddTransient<FormHome>()  
            .AddTransient<Solicitudes>();
        }
    }
}