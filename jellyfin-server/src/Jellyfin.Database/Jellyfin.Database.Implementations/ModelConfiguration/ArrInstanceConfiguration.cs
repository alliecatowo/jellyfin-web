using Jellyfin.Database.Implementations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.Database.Implementations.ModelConfiguration;

/// <summary>
/// Fluent API configuration for <see cref="ArrInstance"/>.
/// </summary>
public class ArrInstanceConfiguration : IEntityTypeConfiguration<ArrInstance>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ArrInstance> builder)
    {
        builder.HasIndex(a => a.Name).IsUnique();
        builder.HasIndex(a => a.Type);
    }
}

