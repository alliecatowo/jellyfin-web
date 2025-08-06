using Jellyfin.Database.Implementations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.Database.Implementations.ModelConfiguration;

/// <summary>
/// FluentAPI configuration for the MediaRequest entity.
/// </summary>
public class MediaRequestConfiguration : IEntityTypeConfiguration<MediaRequest>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MediaRequest> builder)
    {
        builder
            .HasMany(entity => entity.Seasons)
            .WithOne(entity => entity.MediaRequest)
            .HasForeignKey(entity => entity.MediaRequestId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(entity => entity.StatusHistory)
            .WithOne(entity => entity.MediaRequest)
            .HasForeignKey(entity => entity.MediaRequestId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(entity => entity.RequestedBy)
            .WithMany()
            .HasForeignKey(entity => entity.RequestedByUserId);
    }
}
