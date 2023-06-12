namespace SpaceTraders.Api.Models.Interfaces.Ships;

/// <summary>
///     The type of cargo item and the number of units.
/// </summary>
public interface IShipCargoItem : ISymbolModel
{
    /// <summary>
    ///     The name of the cargo item.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    ///     The description of the cargo item type.
    /// </summary>
    string Description { get; set; }

    /// <summary>
    ///     The number of units of the cargo item.
    /// </summary>
    uint Units { get; set; }
}