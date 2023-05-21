using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Systems;

public class System : SymbolModelBase
{
    public string SectorSymbol { get; set; } = null!;

    public SystemType Type { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public IEnumerable<SystemWaypoint> Waypoints { get; set; } = null!;

    public IEnumerable<SystemFaction> Factions { get; set; } = null!;
}