using Jellyfin.Database.Implementations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.Database.Implementations.ModelConfiguration;

/// <summary>
/// Fluent API configuration for <see cref="MediaRequest"/>.
/// </summary>
public class MediaRequestConfiguration : IEntityTypeConfiguration<MediaRequest>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MediaRequest> builder)
    {
        builder
            .HasOne(m => m.RequestedBy)
            .WithMany()
            .HasForeignKey(m => m.RequestedByUserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(m => m.Seasons)
            .WithOne(s => s.MediaRequest)
            .HasForeignKey(s => s.MediaRequestId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(m => m.Status);
        builder.HasIndex(m => m.RequestedByUserId);
        builder.HasIndex(m => new { m.TmdbId, m.MediaType });
    }
}

