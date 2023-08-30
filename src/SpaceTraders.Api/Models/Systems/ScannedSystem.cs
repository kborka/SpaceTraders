using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Systems;

namespace SpaceTraders.Api.Models.Systems;

public class ScannedSystem : CoordinateSymbolModelBase, IScannedSystem
{
    /// <inheritdoc />
    public string SectorSymbol { get; set; } = null!;

    /// <inheritdoc />
    public SystemType Type { get; set; }

    /// <inheritdoc />
    public int Distance { get; set; }
}
