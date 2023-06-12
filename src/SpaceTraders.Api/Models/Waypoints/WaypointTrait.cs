using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Waypoints;

namespace SpaceTraders.Api.Models.Waypoints;

public class WaypointTrait : SymbolModelBase, IWaypointTrait
{
    public WaypointTraitType Type { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
}