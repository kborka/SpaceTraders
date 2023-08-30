using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Systems;

/// <summary>
/// An interface representing a system that was scanned.
/// </summary>
public interface IScannedSystem : ISymbolModel, ICoordinateModel
{
    /// <summary>
    /// Gets or sets the symbol of the sector the system is in.
    /// </summary>
    string SectorSymbol { get; set; }

    /// <summary>
    /// Gets or sets the type of the system.
    /// </summary>
    SystemType Type { get; set; }

    /// <summary>
    /// Gets or sets the distance of the system from the scanning ship.
    /// </summary>
    int Distance { get; set; }
}
