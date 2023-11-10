using AdoptionManager.Domain.Entities.Animals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdoptionManager.Persistance.Configurations.Product
{
    public class AnimalCategoryConfiguration : IEntityTypeConfiguration<AnimalCategory>
    {
        public void Configure(EntityTypeBuilder<AnimalCategory> builder)
        {
            builder.Property(ac => ac.CategoryName).HasMaxLength(50).IsRequired();
        }
    }
}
