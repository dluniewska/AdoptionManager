using Microsoft.EntityFrameworkCore;

namespace AdoptionManager.Persistance
{
    public class AdoptionDbContextFactory : DesignTimeDbContextFactoryBase<AdoptionDbContext>
    {
        protected override AdoptionDbContext CreateNewInstance(DbContextOptions<AdoptionDbContext> options)
        {
            return new AdoptionDbContext(options);
        }
    }
}
