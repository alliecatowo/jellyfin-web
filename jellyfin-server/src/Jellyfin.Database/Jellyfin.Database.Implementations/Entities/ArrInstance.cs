using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Jellyfin.Database.Implementations.Enums;
using Jellyfin.Database.Implementations.Interfaces;

namespace Jellyfin.Database.Implementations.Entities;

/// <summary>
/// Represents a configured *Arr server instance.
/// </summary>
public class ArrInstance : IHasConcurrencyToken
{
    /// <summary>
    /// Gets the identity of the instance.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; private set; }

    /// <summary>
    /// Gets or sets the display name for the instance.
    /// </summary>
    [MaxLength(255)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the base URL of the server.
    /// </summary>
    [MaxLength(1024)]
    public string BaseUrl { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the API key used to authenticate with the server.
    /// </summary>
    [MaxLength(255)]
    public string ApiKey { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the *Arr application type.
    /// </summary>
    public ArrType Type { get; set; }

    /// <summary>
    /// Gets or sets the creation date of this record in UTC.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Gets or sets the last modification date of this record in UTC.
    /// </summary>
    public DateTime DateModified { get; set; }

    /// <inheritdoc />
    [ConcurrencyCheck]
    public uint RowVersion { get; private set; }

    /// <inheritdoc />
    public void OnSavingChanges()
    {
        RowVersion++;
    }
}

