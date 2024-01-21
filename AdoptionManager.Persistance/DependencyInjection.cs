using AdoptionManager.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AdoptionManager.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AdoptionDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("AdoptionManagerDatabase")));

            services.AddScoped<IAdoptionDbContext, AdoptionDbContext>();
            return services;
        }
    }
}
