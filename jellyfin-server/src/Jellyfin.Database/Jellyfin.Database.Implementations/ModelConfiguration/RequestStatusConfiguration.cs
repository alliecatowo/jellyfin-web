using Jellyfin.Database.Implementations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.Database.Implementations.ModelConfiguration;

/// <summary>
/// FluentAPI configuration for the RequestStatus entity.
/// </summary>
public class RequestStatusConfiguration : IEntityTypeConfiguration<RequestStatus>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<RequestStatus> builder)
    {
        builder
            .HasOne(entity => entity.MediaRequest)
            .WithMany(entity => entity.StatusHistory)
            .HasForeignKey(entity => entity.MediaRequestId);
    }
}
