namespace Jellyfin.Database.Implementations.Enums;

/// <summary>
/// Status of a requested media item.
/// </summary>
public enum MediaRequestStatus
{
    /// <summary>
    /// Unspecified status.
    /// </summary>
    None = 0,

    /// <summary>
    /// The request is awaiting approval or processing.
    /// </summary>
    Pending = 1,

    /// <summary>
    /// The request has been approved.
    /// </summary>
    Approved,

    /// <summary>
    /// The request has been declined.
    /// </summary>
    Declined,

    /// <summary>
    /// The request failed while being processed.
    /// </summary>
    Failed,

    /// <summary>
    /// The requested media has been fulfilled and is available.
    /// </summary>
    Completed
}
