using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

public class ShipModificationTransaction : IShipModificationTransaction
{
    /// <inheritdoc />
    public string WaypointSymbol { get; set; } = null!;

    /// <inheritdoc />
    public string ShipSymbol { get; set; } = null!;

    /// <inheritdoc />
    public DateTime Timestamp { get; set; }

    /// <inheritdoc />
    public string TradeSymbol { get; set; } = null!;

    /// <inheritdoc />
    public uint TotalPrice { get; set; }
}
