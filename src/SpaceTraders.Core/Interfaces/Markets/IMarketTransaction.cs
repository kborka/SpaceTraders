using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Markets;

/// <summary>
/// An interface representing a transaction with a market.
/// </summary>
public interface IMarketTransaction : ITransactionModel
{
    /// <summary>
    /// Gets or sets the symbol of the trade good.
    /// </summary>
    string TradeSymbol { get; set; }

    /// <summary>
    /// Gets or sets the type of transaction.
    /// </summary>
    TransactionType Type { get; set; }

    /// <summary>
    /// Gets or sets the number of units of the transaction.
    /// </summary>
    uint Units { get; set; }

    /// <summary>
    /// Gets or sets the price per unit of the transaction.
    /// </summary>
    uint PricePerUnit { get; set; }

    /// <summary>
    /// Gets or sets the total price of the transaction.
    /// </summary>
    uint TotalPrice { get; set; }
}
