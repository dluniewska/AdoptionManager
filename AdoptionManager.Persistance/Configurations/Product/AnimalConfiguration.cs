using AdoptionManager.Domain.Entities.Animals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdoptionManager.Persistance.Configurations.Product
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(30).IsRequired();
            builder.Property(a => a.Species).HasMaxLength(30).IsRequired();
        }
    }
}
