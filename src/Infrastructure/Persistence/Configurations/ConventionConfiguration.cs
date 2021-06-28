using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Talks.Domain.Entities;

namespace Talks.Infrastructure.Persistence.Configurations
{
    public class ConventionConfiguration : IEntityTypeConfiguration<Convention>
    {
        public void Configure(EntityTypeBuilder<Convention> builder)
        {
            builder.Property(t => t.Title)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
