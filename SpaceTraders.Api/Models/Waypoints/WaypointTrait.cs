using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Waypoints;

public class WaypointTrait : SymbolModelBase
{
    public WaypointTraitType Type { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
}