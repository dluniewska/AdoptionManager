using AdoptionManager.Domain.Entities.Shipping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdoptionManager.Persistance.Configurations.Shipping
{
    public class ShippingDataConfiguration : IEntityTypeConfiguration<ShippingData>
    {
        public void Configure(EntityTypeBuilder<ShippingData> builder)
        {
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.ShipmentStatus).HasDefaultValue(ShipmentStatus.PENDING);
        }
    }
}
