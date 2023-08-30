using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Systems;

/// <summary>
/// An interface representing a waypoint found in a system.
/// </summary>
public interface ISystemWaypoint : ISymbolModel, ICoordinateModel
{
    /// <summary>
    /// Gets or sets the type of waypoint this is.
    /// </summary>
    public WaypointType Type { get; set; }
}
