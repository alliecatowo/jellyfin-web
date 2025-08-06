using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Jellyfin.Database.Implementations.Enums;
using Jellyfin.Database.Implementations.Interfaces;

namespace Jellyfin.Database.Implementations.Entities;

/// <summary>
/// Represents a requested season for a TV series.
/// </summary>
public class SeasonRequest : IHasConcurrencyToken
{
    /// <summary>
    /// Gets the identity of this season request.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; private set; }

    /// <summary>
    /// Gets or sets the season number requested.
    /// </summary>
    public int SeasonNumber { get; set; }

    /// <summary>
    /// Gets or sets the status for this season request.
    /// </summary>
    public MediaRequestStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the parent media request.
    /// </summary>
    public int MediaRequestId { get; set; }

    /// <summary>
    /// Gets or sets the parent media request.
    /// </summary>
    public virtual MediaRequest MediaRequest { get; set; } = null!;

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
