using AdoptionManager.Domain.Entities.Surveys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdoptionManager.Persistance.Configurations.Surveys
{
    public class SurveyConfiguration : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.Title).HasMaxLength(50).IsRequired();
            builder.Property(s => s.Description).HasMaxLength(30).IsRequired();
        }
    }
}
