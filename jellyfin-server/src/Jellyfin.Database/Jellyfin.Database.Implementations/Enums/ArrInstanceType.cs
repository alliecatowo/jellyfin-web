using System;

namespace Jellyfin.Database.Implementations.Enums;

/// <summary>
/// Represents the type of *Arr application.
/// </summary>
public enum ArrInstanceType
{
    /// <summary>
    /// Radarr movie manager.
    /// </summary>
    Radarr,

    /// <summary>
    /// Sonarr series manager.
    /// </summary>
    Sonarr,

    /// <summary>
    /// Lidarr music manager.
    /// </summary>
    Lidarr,

    /// <summary>
    /// Readarr book manager.
    /// </summary>
    Readarr
}
