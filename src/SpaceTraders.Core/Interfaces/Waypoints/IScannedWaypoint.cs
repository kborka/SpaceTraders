using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Waypoints;

/// <summary>
/// An interface representing a waypoint that was scanned by a ship.
/// </summary>
public interface IScannedWaypoint : ISymbolModel, ICoordinateModel
{
    /// <summary>
    /// Gets or sets the type of the waypoint.
    /// </summary>
    WaypointType Type { get; set; }

    /// <summary>
    /// Gets or sets the symbol of the system the waypoint is in.
    /// </summary>
    string SystemSymbol { get; set; }

    /// <summary>
    /// Gets or sets a collection of waypoints that orbit this waypoint.
    /// </summary>
    IEnumerable<IWaypointOrbital> Orbitals { get; set; }

    /// <summary>
    /// Gets or sets the faction that controls the waypoint.
    /// </summary>
    IWaypointFaction? Faction { get; set; }

    /// <summary>
    /// Gets or sets a collection of traits of the waypoint.
    /// </summary>
    IEnumerable<IWaypointTrait> Traits { get; set; }

    /// <summary>
    /// Gets or sets the chart of the waypoint.
    /// </summary>
    IChart? Chart { get; set; }
}
