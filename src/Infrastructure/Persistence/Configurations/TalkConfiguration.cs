using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Talks.Domain.Entities;

namespace Talks.Infrastructure.Persistence.Configurations
{
    public class TalkConfiguration : IEntityTypeConfiguration<Talk>
    {
        public void Configure(EntityTypeBuilder<Talk> builder)
        {
            builder.Property(t => t.Title)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(t => t.SpeakerId)
                .IsRequired();
        }
    }
}
