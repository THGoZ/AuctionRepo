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
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var subastaprogram = serviceProvider.GetRequiredService<FormHome>();
                subastaprogram.ShowDialog();
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
            .AddTransient<FormHome> ();

        }
    }
}