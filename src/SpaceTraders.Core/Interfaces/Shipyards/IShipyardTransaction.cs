using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Shipyards;

/// <summary>
/// An interface representing a transaction with a shipyard.
/// </summary>
public interface IShipyardTransaction : ITransactionModel
{
    /// <summary>
    /// Gets or sets the price of the transaction.
    /// </summary>
    uint Price { get; set; }

    /// <summary>
    /// Gets or sets the symbol of the agent that made the transaction.
    /// </summary>
    string AgentSymbol { get; set; }
}
