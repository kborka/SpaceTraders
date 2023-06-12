namespace SpaceTraders.Api.Models.Interfaces.Ships;

public interface IShipCargo
{
    /// <summary>
    ///     The max number of items that can be stored in the cargo hold.
    /// </summary>
    uint Capacity { get; set; }

    /// <summary>
    ///     The number of items currently stored in the cargo hold.
    /// </summary>
    uint Units { get; set; }

    /// <summary>
    ///     The items currently in the cargo hold.
    /// </summary>
    IEnumerable<IShipCargoItem> Inventory { get; set; }
}