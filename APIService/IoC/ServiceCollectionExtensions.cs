using APIService.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace APIService.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApiClientService(this IServiceCollection services,
            Action<APICLientOptions> options)
        {
            services.Configure(options);
            services.AddSingleton(provider =>
            {
                var options = provider.GetRequiredService<IOptions<APICLientOptions>>().Value;
                return new APIService(options);
            });
        }
    }
}
