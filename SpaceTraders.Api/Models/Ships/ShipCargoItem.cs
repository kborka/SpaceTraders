namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     The type of cargo item and the number of units.
/// </summary>
public class ShipCargoItem : SymbolModelBase
{
    /// <summary>
    ///     The name of the cargo item.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    ///     The description of the cargo item type.
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    ///     The number of units of the cargo item.
    /// </summary>
    public uint Units { get; set; }
}