using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Systems;

namespace SpaceTraders.Api.Models.Systems;

public class ConnectedSystem : CoordinateSymbolModelBase, IConnectedSystem
{
    public string SectorSymbol { get; set; } = null!;

    public SystemType Type { get; set; }

    /// <summary>
    ///     The symbol of the faction that owns the connected jump gate in the system.
    /// </summary>
    public string? FactionSymbol { get; set; }

    public int Distance { get; set; }
}