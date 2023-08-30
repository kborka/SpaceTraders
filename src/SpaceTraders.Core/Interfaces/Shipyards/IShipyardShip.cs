using SpaceTraders.Core.Interfaces.Core;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Core.Interfaces.Shipyards;

/// <summary>
/// An interface representing a ship found in a shipyard.
/// </summary>
public interface IShipyardShip : INameableModel, IDescriptableModel
{
    /// <summary>
    /// Gets or sets the price to purchase the ship.
    /// </summary>
    int PurchasePrice { get; set; }

    /// <summary>
    /// Gets or sets the installed frame.
    /// </summary>
    IShipFrame Frame { get; set; }

    /// <summary>
    /// Gets or sets the installed reactor.
    /// </summary>
    IShipReactor Reactor { get; set; }

    /// <summary>
    /// Gets or sets the installed engine.
    /// </summary>
    IShipEngine Engine { get; set; }

    /// <summary>
    /// Gets or sets the installed modules.
    /// </summary>
    IEnumerable<IShipModule> Modules { get; set; }

    /// <summary>
    /// Gets or sets the installed mounts.
    /// </summary>
    IEnumerable<IShipMount> Mounts { get; set; }
}
