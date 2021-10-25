using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using SoGest.Infrasturcture.DependencyInjection.Modules;

namespace SoGest.Infrasturcture.DependencyInjection
{
    public static class Extensions
    {
        public static void RegisterServices ( this IServiceCollection service, IConfiguration configuration )
        {

            RepositoryModule.Configure(service, configuration);
        }
    }
}
