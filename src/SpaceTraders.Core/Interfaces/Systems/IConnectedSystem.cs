using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Systems;

/// <summary>
/// An interface representing a system within the range of a gate that has a corresponding gate.
/// </summary>
public interface IConnectedSystem : ISymbolModel, ICoordinateModel
{
    /// <summary>
    /// Gets or sets the symbol of this sector this system is in.
    /// </summary>
    string SectorSymbol { get; set; }

    /// <summary>
    /// Gets or sets the type of the system.
    /// </summary>
    SystemType Type { get; set; }

    /// <summary>
    /// The symbol of the faction that owns the connected jump gate in the system.
    /// </summary>
    string? FactionSymbol { get; set; }

    /// <summary>
    /// Gets or sets the distance of the system to the connected jump gate.
    /// </summary>
    int Distance { get; set; }
}
