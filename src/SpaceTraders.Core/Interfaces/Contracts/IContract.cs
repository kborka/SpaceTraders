using SpaceTraders.Core.Enums;

namespace SpaceTraders.Core.Interfaces.Contracts;

public interface IContract
{
    /// <summary>
    /// The ID of the contract.
    /// </summary>
    string Id { get; set; }

    /// <summary>
    /// The symbol of the faction that this contract is for.
    /// </summary>
    string FactionSymbol { get; set; }

    /// <summary>
    /// The type of the contract.
    /// </summary>
    ContractType Type { get; set; }

    /// <summary>
    /// The terms of the contract needed to fulfill it.
    /// </summary>
    IContractTerms Terms { get; set; }

    /// <summary>
    /// Whether the contract has been accepted by the agent.
    /// </summary>
    public bool Accepted { get; set; }

    /// <summary>
    /// Whether the contract has been fulfilled.
    /// </summary>
    public bool Fulfilled { get; set; }

    /// <summary>
    /// The time at which the contract is no longer available to be accepted.
    /// </summary>
    public DateTime? DeadlineToAccept { get; set; }
}
