using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
/// The type of cargo item and the number of units.
/// </summary>
public class ShipCargoItem : SymbolModelBase, IShipCargoItem
{
    /// <inheritdoc />
    public string Name { get; set; } = null!;

    /// <inheritdoc />
    public string Description { get; set; } = null!;

    /// <inheritdoc />
    public uint Units { get; set; }
}
