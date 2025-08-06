using Jellyfin.Database.Implementations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.Database.Implementations.ModelConfiguration;

/// <summary>
/// FluentAPI configuration for the ArrInstance entity.
/// </summary>
public class ArrInstanceConfiguration : IEntityTypeConfiguration<ArrInstance>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ArrInstance> builder)
    {
        // No additional configuration required yet.
    }
}
