using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces;
using SpaceTraders.Api.Models.Interfaces.Waypoints;

namespace SpaceTraders.Api.Models.Waypoints;

/// <summary>
///     A waypoint is a location that ships can travel to such as a Planet, Moon, or Space Station
/// </summary>
public class ScannedWaypoint : CoordinateSymbolModelBase, IScannedWaypoint
{
    public WaypointType Type { get; set; }

    public string SystemSymbol { get; set; } = null!;

    public IEnumerable<IWaypointOrbital> Orbitals { get; set; } = null!;

    public IWaypointFaction? Faction { get; set; }

    public IEnumerable<IWaypointTrait> Traits { get; set; } = null!;

    public IChart? Chart { get; set; }
}