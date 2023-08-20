using AdoptionManager.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdoptionManager.Persistance.Configurations.Users
{
    public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.Property(o => o.Id).UseIdentityColumn();
            builder.OwnsOne(o => o.Email).HasIndex(e => new { e.UserName, e.DomainName }).IsUnique();
        }
    }
}
