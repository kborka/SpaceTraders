using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// The type of cargo item and the number of units.
/// </summary>
public interface IShipCargoItem : ISymbolModel, INameableModel, IDescriptableModel
{
    /// <summary>
    /// The number of units of the cargo item.
    /// </summary>
    uint Units { get; set; }
}
