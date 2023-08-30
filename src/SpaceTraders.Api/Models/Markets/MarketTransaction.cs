using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Markets;

namespace SpaceTraders.Api.Models.Markets;

public class MarketTransaction : IMarketTransaction
{
    /// <inheritdoc />
    public string WaypointSymbol { get; set; } = null!;

    /// <inheritdoc />
    public string ShipSymbol { get; set; } = null!;

    /// <inheritdoc />
    public string TradeSymbol { get; set; } = null!;

    /// <inheritdoc />
    public TransactionType Type { get; set; }

    /// <inheritdoc />
    public uint Units { get; set; }

    /// <inheritdoc />
    public uint PricePerUnit { get; set; }

    /// <inheritdoc />
    public uint TotalPrice { get; set; }

    /// <inheritdoc />
    public DateTime Timestamp { get; set; }
}
