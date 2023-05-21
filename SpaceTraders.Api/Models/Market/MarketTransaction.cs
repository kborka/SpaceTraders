using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Market;

public class MarketTransaction
{
    /// <summary>
    ///     The symbol of the waypoint where the transaction took place.
    /// </summary>
    public string WayPointSymbol { get; set; } = null!;

    /// <summary>
    ///     The symbol of the ship that made the transaction.
    /// </summary>
    public string ShipSymbol { get; set; } = null!;

    /// <summary>
    ///     The symbol of the trade good.
    /// </summary>
    public string TradeSymbol { get; set; } = null!;

    /// <summary>
    ///     The type of transaction.
    /// </summary>
    public TransactionType Type { get; set; }

    /// <summary>
    ///     The number of units of the transaction.
    /// </summary>
    public uint Units { get; set; }

    /// <summary>
    ///     The price per unit of the transaction.
    /// </summary>
    public uint PricePerUnit { get; set; }

    /// <summary>
    ///     The total price of the transaction.
    /// </summary>
    public uint TotalPrice { get; set; }

    /// <summary>
    ///     The timestamp of the transaction.
    /// </summary>
    public DateTime Timestamp { get; set; }
}