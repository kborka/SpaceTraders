using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Shipyards;

namespace SpaceTraders.Api.Models.Shipyards;

public class Shipyard : SymbolModelBase, IShipyard
{
    /// <inheritdoc/>
    public IEnumerable<ShipType> ShipTypes { get; set; } = null!;

    /// <inheritdoc/>
    public IEnumerable<IShipyardTransaction>? Transactions { get; set; }

    /// <inheritdoc/>
    public IEnumerable<IShipyardShip>? Ships { get; set; }
}
