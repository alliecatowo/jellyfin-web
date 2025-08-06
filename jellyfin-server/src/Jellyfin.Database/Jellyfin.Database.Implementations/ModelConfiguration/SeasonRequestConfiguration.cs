using Jellyfin.Database.Implementations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.Database.Implementations.ModelConfiguration;

/// <summary>
/// FluentAPI configuration for the SeasonRequest entity.
/// </summary>
public class SeasonRequestConfiguration : IEntityTypeConfiguration<SeasonRequest>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<SeasonRequest> builder)
    {
        builder
            .HasOne(entity => entity.MediaRequest)
            .WithMany(entity => entity.Seasons)
            .HasForeignKey(entity => entity.MediaRequestId);
    }
}
