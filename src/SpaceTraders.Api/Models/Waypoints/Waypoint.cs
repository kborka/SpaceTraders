using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Waypoints;

namespace SpaceTraders.Api.Models.Waypoints;

/// <summary>
/// A waypoint is a location that ships can travel to such as a Planet, Moon, or Space Station.
/// </summary>
public class Waypoint : CoordinateSymbolModelBase, IWaypoint
{
    /// <inheritdoc />
    public WaypointType Type { get; set; }

    /// <inheritdoc />
    public string SystemSymbol { get; set; } = null!;

    /// <inheritdoc />
    public IEnumerable<IWaypointOrbital> Orbitals { get; set; } = null!;

    /// <inheritdoc />
    public IWaypointFaction? Faction { get; set; }

    /// <inheritdoc />
    public IEnumerable<IWaypointTrait> Traits { get; set; } = null!;

    /// <inheritdoc />
    public IChart? Chart { get; set; }
}
