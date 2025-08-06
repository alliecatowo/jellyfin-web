using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Jellyfin.Database.Implementations.Enums;
using Jellyfin.Database.Implementations.Interfaces;

namespace Jellyfin.Database.Implementations.Entities;

/// <summary>
/// Represents a request for media to be added to the library.
/// </summary>
public class MediaRequest : IHasConcurrencyToken
{
    /// <summary>
    /// Gets the identity of this media request.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; private set; }

    /// <summary>
    /// Gets or sets the user identifier that made the request.
    /// </summary>
    public Guid RequestedByUserId { get; set; }

    /// <summary>
    /// Gets or sets the user that made the request.
    /// </summary>
    public virtual User RequestedBy { get; set; } = null!;

    /// <summary>
    /// Gets or sets the TheMovieDB identifier for the media.
    /// </summary>
    public int TmdbId { get; set; }

    /// <summary>
    /// Gets or sets the TVDB identifier for the media, if available.
    /// </summary>
    public int? TvdbId { get; set; }

    /// <summary>
    /// Gets or sets the type of media being requested.
    /// </summary>
    public MediaRequestType MediaType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the request is for a 4K version.
    /// </summary>
    public bool Is4K { get; set; }

    /// <summary>
    /// Gets or sets the current status of the request.
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

    /// <summary>
    /// Gets the season requests associated with this media request.
    /// </summary>
    public virtual ICollection<SeasonRequest> Seasons { get; } = new HashSet<SeasonRequest>();

    /// <summary>
    /// Gets the status history for this request.
    /// </summary>
    public virtual ICollection<RequestStatus> StatusHistory { get; } = new HashSet<RequestStatus>();

    /// <inheritdoc />
    [ConcurrencyCheck]
    public uint RowVersion { get; private set; }

    /// <inheritdoc />
    public void OnSavingChanges()
    {
        RowVersion++;
    }
}
