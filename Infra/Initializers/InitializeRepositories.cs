using Infra.Repositories.BrewerieRepository;
using Infra.Repositories.WholeSalerRepository;
using Microsoft.Extensions.DependencyInjection;
using Model.Interfaces;


namespace Infra.Initializers
{
    public static class InitializeRepositories
    {
        public static void Initialize(this IServiceCollection services)
        {
            services.AddScoped<IBrewerieRepository, BrewerieRepository>();
            services.AddScoped<IWholeSalerRepository, WholeSalerRepository>();
        }
    }
}
