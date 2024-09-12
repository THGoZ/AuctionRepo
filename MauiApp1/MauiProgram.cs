using MauiApp1.Caller;
using MauiApp1.Caller.Interfases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;


namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            //var random = AssemblyName.GetAssemblyName(Assembly.GetExecutingAssembly().Location).Name;

            #region Json de configuracion de api
            var a = Assembly.GetExecutingAssembly();
            using var stream = a.GetManifestResourceStream("MauiApp1.appsettings.json");



            var config = new ConfigurationBuilder()
                        .AddJsonStream(stream)
                        .Build();


            builder.Configuration.AddConfiguration(config);


            var ApiAdress = new MAUIClientOptions() { ApiBaseAddress = config.GetValue<string>("ApiBaseAdress") };

            #endregion


            builder.Services.AddScoped(p => ApiAdress);
            builder.Services.AddScoped<IAPIMaui, APIMaui>();
            builder.Services.AddTransient<MainPage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
