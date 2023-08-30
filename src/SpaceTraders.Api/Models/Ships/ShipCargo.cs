using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

public class ShipCargo : IShipCargo
{
    /// <inheritdoc />
    public uint Capacity { get; set; }

    /// <inheritdoc />
    public uint Units { get; set; }

    /// <inheritdoc />
    public IEnumerable<IShipCargoItem> Inventory { get; set; } = null!;
}
