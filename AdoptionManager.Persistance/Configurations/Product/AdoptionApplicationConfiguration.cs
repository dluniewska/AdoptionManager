using AdoptionManager.Domain.Entities.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdoptionManager.Persistance.Configurations.Product
{
    public class AdoptionApplicationConfiguration : IEntityTypeConfiguration<AdoptionApplication>
    {
        public void Configure(EntityTypeBuilder<AdoptionApplication> builder) { }
    }
}
