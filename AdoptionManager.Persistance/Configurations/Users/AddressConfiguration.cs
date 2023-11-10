using AdoptionManager.Domain.Entities.Users.Addresses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Net;

namespace AdoptionManager.Persistance.Configurations.Users
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.OwnsOne(a => a.AddressObj);
        }
    }
}
