using AdoptionManager.Domain.Entities.Surveys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdoptionManager.Persistance.Configurations.Surveys
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.Property(a => a.Text).HasMaxLength(300).IsRequired();
        }
    }
}
