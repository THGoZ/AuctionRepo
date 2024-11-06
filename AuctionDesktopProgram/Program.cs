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
            .AddTransient<FormProductos>()
            .AddTransient<FormHome>()
            .AddTransient<Solicitudes>()
            .AddTransient<CrearSubastaForm>()
            .AddTransient<Informes>()
            .AddTransient<Ganancias>()
            .AddTransient<FormVendidos>()
            .AddTransient<ProductosNoOfertados>();
            //services.AddSingleton<FormProductos>();
            services.AddSingleton<Mainpage>();
        }
    }
}