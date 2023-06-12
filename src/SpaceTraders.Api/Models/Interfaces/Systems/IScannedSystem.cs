using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Systems;

public interface IScannedSystem : ISymbolModel, ICoordinateModel
{
    string SectorSymbol { get; set; }

    SystemType Type { get; set; }

    int Distance { get; set; }
}