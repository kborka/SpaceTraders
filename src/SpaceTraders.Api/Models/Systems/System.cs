using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Systems;

namespace SpaceTraders.Api.Models.Systems;

public class System : CoordinateSymbolModelBase, ISystem
{
    /// <inheritdoc />
    public string SectorSymbol { get; set; } = null!;

    /// <inheritdoc />
    public SystemType Type { get; set; }

    /// <inheritdoc />
    public IEnumerable<ISystemWaypoint> Waypoints { get; set; } = null!;

    /// <inheritdoc />
    public IEnumerable<ISystemFaction> Factions { get; set; } = null!;
}
