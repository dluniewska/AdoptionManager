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
            builder.Property(o => o.Name).HasMaxLength(50).IsRequired();
            builder.Property(o => o.Description).HasMaxLength(300).IsRequired();

            builder.OwnsOne(o => o.Email).HasIndex(e => new { e.UserName, e.DomainName }).IsUnique();
        }
    }
}
