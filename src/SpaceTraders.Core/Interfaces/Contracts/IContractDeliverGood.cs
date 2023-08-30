namespace SpaceTraders.Core.Interfaces.Contracts;

/// <summary>
/// The details of the delivery contract. Includes the type of good, units needed, and the destination.
/// </summary>
public interface IContractDeliverGood
{
    /// <summary>
    /// The symbol of the trade good to deliver.
    /// </summary>
    string TradeSymbol { get; set; }

    /// <summary>
    /// The destination where goods need to be delivered.
    /// </summary>
    string DestinationSymbol { get; set; }

    /// <summary>
    /// The number of units that need to be delivered on this contract.
    /// </summary>
    int UnitsRequired { get; set; }

    /// <summary>
    /// The number of units fulfilled on this contract.
    /// </summary>
    int UnitsFulfilled { get; set; }
}
