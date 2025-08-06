using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Jellyfin.Database.Implementations.Enums;
using Jellyfin.Database.Implementations.Interfaces;

namespace Jellyfin.Database.Implementations.Entities;

/// <summary>
/// Represents a historical status entry for a media request.
/// </summary>
public class RequestStatus : IHasConcurrencyToken
{
    /// <summary>
    /// Gets the identity of this status entry.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; private set; }

    /// <summary>
    /// Gets or sets the associated media request identifier.
    /// </summary>
    public int MediaRequestId { get; set; }

    /// <summary>
    /// Gets or sets the associated media request.
    /// </summary>
    public virtual MediaRequest MediaRequest { get; set; } = null!;

    /// <summary>
    /// Gets or sets the status value.
    /// </summary>
    public MediaRequestStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the creation date in UTC.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Gets or sets the last modification date in UTC.
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
