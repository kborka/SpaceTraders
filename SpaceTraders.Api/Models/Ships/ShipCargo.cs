using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

public class ShipCargo : IShipCargo
{
    /// <summary>
    ///     The max number of items that can be stored in the cargo hold.
    /// </summary>
    public uint Capacity { get; set; }

    /// <summary>
    ///     The number of items currently stored in the cargo hold.
    /// </summary>
    public uint Units { get; set; }

    /// <summary>
    ///     The items currently in the cargo hold.
    /// </summary>
    public IEnumerable<IShipCargoItem> Inventory { get; set; } = null!;
}