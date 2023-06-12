using SpaceTraders.Api.Models.Interfaces.Contracts;

namespace SpaceTraders.Api.Models.Contracts;

/// <summary>
///     The details of the delivery contract. Includes the type of good, units needed, and the destination.
/// </summary>
public class ContractDeliverGood : IContractDeliverGood
{
    /// <summary>
    ///     The symbol of the trade good to deliver.
    /// </summary>
    public string TradeSymbol { get; set; } = null!;

    /// <summary>
    ///     The destination where goods need to be delivered.
    /// </summary>
    public string DestinationSymbol { get; set; } = null!;

    /// <summary>
    ///     The number of units that need to be delivered on this contract.
    /// </summary>
    public int UnitsRequired { get; set; }

    /// <summary>
    ///     The number of units fulfilled on this contract.
    /// </summary>
    public int UnitsFulfilled { get; set; }
}