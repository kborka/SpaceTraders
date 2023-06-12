using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Waypoints;

public interface IWaypointTrait : ISymbolModel
{
    WaypointTraitType Type { get; set; }

    string Name { get; set; }

    string Description { get; set; }
}