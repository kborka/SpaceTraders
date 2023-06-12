using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Systems;

namespace SpaceTraders.Api.Models.Systems;

public class System : CoordinateSymbolModelBase, ISystem
{
    public string SectorSymbol { get; set; } = null!;

    public SystemType Type { get; set; }

    public IEnumerable<ISystemWaypoint> Waypoints { get; set; } = null!;

    public IEnumerable<ISystemFaction> Factions { get; set; } = null!;
}