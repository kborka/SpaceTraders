using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Waypoints;

namespace SpaceTraders.Api.Models.Waypoints;

/// <summary>
/// An orbital is another waypoint that orbits a parent waypoint.
/// </summary>
public class WaypointOrbital : SymbolModelBase, IWaypointOrbital
{
}
