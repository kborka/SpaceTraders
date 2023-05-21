using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Waypoints;

/// <summary>
///     A waypoint is a location that ships can travel to such as a Planet, Moon, or Space Station
/// </summary>
public class ScannedWaypoint : SymbolModelBase
{
    public WaypointType Type { get; set; }

    public string SystemSymbol { get; set; } = null!;

    public int X { get; set; }

    public int Y { get; set; }

    public IEnumerable<WaypointOrbital> Orbitals { get; set; } = null!;

    public WaypointFaction? Faction { get; set; }

    public IEnumerable<WaypointTrait> Traits { get; set; } = null!;

    public Chart? Chart { get; set; }
}