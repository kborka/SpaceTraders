using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Systems;

public class ScannedSystem : SymbolModelBase
{
    public string SectorSymbol { get; set; } = null!;

    public SystemType Type { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public int Distance { get; set; }
}