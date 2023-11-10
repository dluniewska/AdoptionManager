using AdoptionManager.Domain.Entities.Animals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdoptionManager.Persistance.Configurations.Product
{
    public class AdoptionOfferConfiguration : IEntityTypeConfiguration<AdoptionOffer>
    {
        public void Configure(EntityTypeBuilder<AdoptionOffer> builder)
        {
            builder.Property(ao => ao.QuatntityInStock).IsRequired();
            builder.Property(ao => ao.Description).HasMaxLength(300).IsRequired();
        }
    }
}
