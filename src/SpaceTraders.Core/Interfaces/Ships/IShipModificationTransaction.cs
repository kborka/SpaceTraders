using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// An interface representing a transaction for a ship modification, such as installing a mount or module.
/// </summary>
public interface IShipModificationTransaction : ITransactionModel
{
    /// <summary>
    /// Gets or sets the symbol of the trade good involved in the modification.
    /// </summary>
    string TradeSymbol { get; set; }

    /// <summary>
    /// Gets or sets the total price of the transaction.
    /// </summary>
    uint TotalPrice { get; set; }
}
