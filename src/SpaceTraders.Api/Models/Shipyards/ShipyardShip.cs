using SpaceTraders.Core.Interfaces.Ships;
using SpaceTraders.Core.Interfaces.Shipyards;

namespace SpaceTraders.Api.Models.Shipyards;

public class ShipyardShip : IShipyardShip
{
    /// <inheritdoc/>
    public string Name { get; set; } = null!;

    /// <inheritdoc/>
    public string Description { get; set; } = null!;

    /// <inheritdoc/>
    public int PurchasePrice { get; set; }

    /// <inheritdoc/>
    public IShipFrame Frame { get; set; } = null!;

    /// <inheritdoc/>
    public IShipReactor Reactor { get; set; } = null!;

    /// <inheritdoc/>
    public IShipEngine Engine { get; set; } = null!;

    /// <inheritdoc/>
    public IEnumerable<IShipModule> Modules { get; set; } = null!;

    /// <inheritdoc/>
    public IEnumerable<IShipMount> Mounts { get; set; } = null!;
}
