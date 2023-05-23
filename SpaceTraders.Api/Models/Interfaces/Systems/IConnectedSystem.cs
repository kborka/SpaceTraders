using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Systems;

public interface IConnectedSystem : ISymbolModel, ICoordinateModel
{
    string SectorSymbol { get; set; }

    SystemType Type { get; set; }

    /// <summary>
    ///     The symbol of the faction that owns the connected jump gate in the system.
    /// </summary>
    string? FactionSymbol { get; set; }

    int Distance { get; set; }
}