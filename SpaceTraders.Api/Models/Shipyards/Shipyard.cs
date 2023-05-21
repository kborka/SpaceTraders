using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Shipyards;

public class Shipyard : SymbolModelBase
{
    /// <summary>
    ///     The list of ship types available for purchase at this shipyard.
    /// </summary>
    public IEnumerable<ShipType> ShipTypes { get; set; } = null!;

    /// <summary>
    ///     The list of recent transactions at this shipyard.
    /// </summary>
    public IEnumerable<ShipyardTransaction>? Transactions { get; set; }

    /// <summary>
    ///     The ships that are currently available for purchase at the shipyard.
    /// </summary>
    public IEnumerable<ShipyardShip>? Ships { get; set; }
}