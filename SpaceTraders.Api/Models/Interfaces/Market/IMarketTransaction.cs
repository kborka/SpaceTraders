using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Market;

public interface IMarketTransaction
{
    /// <summary>
    ///     The symbol of the waypoint where the transaction took place.
    /// </summary>
    string WayPointSymbol { get; set; }

    /// <summary>
    ///     The symbol of the ship that made the transaction.
    /// </summary>
    string ShipSymbol { get; set; }

    /// <summary>
    ///     The symbol of the trade good.
    /// </summary>
    string TradeSymbol { get; set; }

    /// <summary>
    ///     The type of transaction.
    /// </summary>
    TransactionType Type { get; set; }

    /// <summary>
    ///     The number of units of the transaction.
    /// </summary>
    uint Units { get; set; }

    /// <summary>
    ///     The price per unit of the transaction.
    /// </summary>
    uint PricePerUnit { get; set; }

    /// <summary>
    ///     The total price of the transaction.
    /// </summary>
    uint TotalPrice { get; set; }

    /// <summary>
    ///     The timestamp of the transaction.
    /// </summary>
    DateTime Timestamp { get; set; }
}