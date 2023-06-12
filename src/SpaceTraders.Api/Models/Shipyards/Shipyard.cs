using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Shipyards;

namespace SpaceTraders.Api.Models.Shipyards;

public class Shipyard : SymbolModelBase, IShipyard
{
    /// <summary>
    ///     The list of ship types available for purchase at this shipyard.
    /// </summary>
    public IEnumerable<ShipType> ShipTypes { get; set; } = null!;

    /// <summary>
    ///     The list of recent transactions at this shipyard.
    /// </summary>
    public IEnumerable<IShipyardTransaction>? Transactions { get; set; }

    /// <summary>
    ///     The ships that are currently available for purchase at the shipyard.
    /// </summary>
    public IEnumerable<IShipyardShip>? Ships { get; set; }
}