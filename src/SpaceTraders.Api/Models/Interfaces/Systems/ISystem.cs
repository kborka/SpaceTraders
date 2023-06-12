using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Systems;

public interface ISystem : ISymbolModel, ICoordinateModel
{
    string SectorSymbol { get; set; }

    SystemType Type { get; set; }

    IEnumerable<ISystemWaypoint> Waypoints { get; set; }

    IEnumerable<ISystemFaction> Factions { get; set; }
}