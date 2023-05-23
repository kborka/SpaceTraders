using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Systems;

namespace SpaceTraders.Api.Models.Systems;

public class ScannedSystem : CoordinateSymbolModelBase, IScannedSystem
{
    public string SectorSymbol { get; set; } = null!;

    public SystemType Type { get; set; }

    public int Distance { get; set; }
}