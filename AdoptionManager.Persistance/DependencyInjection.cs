using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AdoptionManager.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AdoptionDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("AdoptionManagerDatabase")));

            return services;
        }
    }
}
