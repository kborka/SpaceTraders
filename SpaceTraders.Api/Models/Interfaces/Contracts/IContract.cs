using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Contracts;

public interface IContract
{
    string Id { get; set; }

    /// <summary>
    ///     The symbol of the faction that this contract is for.
    /// </summary>
    string FactionSymbol { get; set; }

    ContractType Type { get; set; }

    IContractTerms Terms { get; set; }

    /// <summary>
    ///     Whether the contract has been accepted by the agent.
    /// </summary>
    public bool Accepted { get; set; }

    /// <summary>
    ///     Whether the contract has been fulfilled.
    /// </summary>
    public bool Fulfilled { get; set; }

    /// <summary>
    ///     The time at which the contract is no longer available to be accepted.
    /// </summary>
    public DateTime? DeadlineToAccept { get; set; }
}