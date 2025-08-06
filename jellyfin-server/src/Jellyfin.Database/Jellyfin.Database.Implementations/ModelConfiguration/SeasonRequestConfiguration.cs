using Jellyfin.Database.Implementations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.Database.Implementations.ModelConfiguration;

/// <summary>
/// Fluent API configuration for <see cref="SeasonRequest"/>.
/// </summary>
public class SeasonRequestConfiguration : IEntityTypeConfiguration<SeasonRequest>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<SeasonRequest> builder)
    {
        builder
            .HasOne(s => s.MediaRequest)
            .WithMany(m => m.Seasons)
            .HasForeignKey(s => s.MediaRequestId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(s => new { s.MediaRequestId, s.SeasonNumber }).IsUnique();
    }
}

