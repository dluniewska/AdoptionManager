using AdoptionManager.Domain.Entities.Shipping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdoptionManager.Persistance.Configurations.Shipping
{
    public class ShippingMethodConfiguration : IEntityTypeConfiguration<ShippingMethod>
    {
        public void Configure(EntityTypeBuilder<ShippingMethod> builder)
        {
            builder.Property(sm => sm.Description).HasMaxLength(300).IsRequired();
            builder.Property(sm => sm.ShippingType).HasDefaultValue(ShippingType.VOLUNTEER).IsRequired();
        }
    }
}
