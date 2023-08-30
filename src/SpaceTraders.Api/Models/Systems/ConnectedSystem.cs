using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Systems;

namespace SpaceTraders.Api.Models.Systems;

public class ConnectedSystem : CoordinateSymbolModelBase, IConnectedSystem
{
    /// <inheritdoc />
    public string SectorSymbol { get; set; } = null!;

    /// <inheritdoc />
    public SystemType Type { get; set; }

    /// <inheritdoc />
    public string? FactionSymbol { get; set; }

    /// <inheritdoc />
    public int Distance { get; set; }
}
