namespace Jellyfin.Database.Implementations.Enums;

/// <summary>
/// Types of media that can be requested.
/// </summary>
public enum MediaRequestType
{
    /// <summary>
    /// Unspecified media type.
    /// </summary>
    None = 0,

    /// <summary>
    /// A movie request.
    /// </summary>
    Movie = 1,

    /// <summary>
    /// A television series request.
    /// </summary>
    Tv = 2
}
