using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;

using WCM.WebApi.Services;

namespace WCM.WebApi.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient("Refit", op =>
            {                
                op.BaseAddress = new System.Uri(configuration.GetSection("URLMovieCup").Value);
            })
            .AddTypedClient(Refit.RestService.For<IMoviesService>);


            services.AddTransient<IChampionshipService ,ChampionshipService>();
            
        }
    }
}