using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Waypoints;

/// <summary>
/// A waypoint is a location that ships can travel to such as a Planet, Moon, or Space Station.
/// </summary>
public interface IWaypoint : ISymbolModel, ICoordinateModel
{
    /// <summary>
    /// Gets or sets the type of the waypoint.
    /// </summary>
    WaypointType Type { get; set; }

    /// <summary>
    /// Gets or sets the symbol of the sector this waypoint belongs to.
    /// </summary>
    string SystemSymbol { get; set; }

    /// <summary>
    /// Gets or sets the waypoints that orbit this waypoint.
    /// </summary>
    IEnumerable<IWaypointOrbital> Orbitals { get; set; }

    /// <summary>
    /// Gets or sets the faction that controls this waypoint.
    /// </summary>
    IWaypointFaction? Faction { get; set; }

    /// <summary>
    /// Gets or sets the traits of the waypoint.
    /// </summary>
    IEnumerable<IWaypointTrait> Traits { get; set; }

    /// <summary>
    /// Gets or sets the chart of the waypoint, which makes the location visible to other agents.
    /// </summary>
    IChart? Chart { get; set; }
}
