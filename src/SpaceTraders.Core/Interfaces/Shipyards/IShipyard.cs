using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Shipyards;

/// <summary>
/// An interface representing a shipyard.
/// </summary>
public interface IShipyard : ISymbolModel
{
    /// <summary>
    /// The list of ship types available for purchase at this shipyard.
    /// </summary>
    IEnumerable<ShipType> ShipTypes { get; set; }

    /// <summary>
    /// The list of recent transactions at this shipyard.
    /// </summary>
    IEnumerable<IShipyardTransaction>? Transactions { get; set; }

    /// <summary>
    /// The ships that are currently available for purchase at the shipyard.
    /// </summary>
    IEnumerable<IShipyardShip>? Ships { get; set; }
}
