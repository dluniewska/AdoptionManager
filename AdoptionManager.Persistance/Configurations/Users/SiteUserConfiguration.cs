using AdoptionManager.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdoptionManager.Persistance.Configurations.Users
{
    public class SiteUserConfiguration : IEntityTypeConfiguration<SiteUser>
    {
        public void Configure(EntityTypeBuilder<SiteUser> builder)
        {
            builder.Property(su => su.Id).UseIdentityColumn();
            builder.Property(su => su.Role).HasDefaultValue(RoleType.USER).IsRequired();

            builder.OwnsOne(su => su.Email).HasIndex(e => new { e.UserName, e.DomainName }).IsUnique();
        }
    }
}
