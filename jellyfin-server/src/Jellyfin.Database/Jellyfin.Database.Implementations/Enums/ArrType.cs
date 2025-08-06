namespace Jellyfin.Database.Implementations.Enums;

/// <summary>
/// Defines the available *Arr application types.
/// </summary>
public enum ArrType
{
    /// <summary>
    /// The Radarr movie manager.
    /// </summary>
    Radarr,

    /// <summary>
    /// The Sonarr series manager.
    /// </summary>
    Sonarr,

    /// <summary>
    /// The Lidarr music manager.
    /// </summary>
    Lidarr,

    /// <summary>
    /// The Readarr book manager.
    /// </summary>
    Readarr,
}

