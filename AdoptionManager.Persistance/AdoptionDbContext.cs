using Microsoft.EntityFrameworkCore;

namespace AdoptionManager.Persistance
{
    public class AdoptionDbContext : DbContext
    {
        public AdoptionDbContext(DbContextOptions<AdoptionDbContext> options) : base(options) { }
    }
}
