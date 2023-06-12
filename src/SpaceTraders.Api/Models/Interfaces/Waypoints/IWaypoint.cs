using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Waypoints;

/// <summary>
///     A waypoint is a location that ships can travel to such as a Planet, Moon, or Space Station.
/// </summary>
public interface IWaypoint : ISymbolModel, ICoordinateModel
{
    WaypointType Type { get; set; }

    string SystemSymbol { get; set; }

    IEnumerable<IWaypointOrbital> Orbitals { get; set; }

    IWaypointFaction? Faction { get; set; }

    IEnumerable<IWaypointTrait> Traits { get; set; }

    IChart? Chart { get; set; }
}