using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Contracts;

public class Contract
{
    public string Id { get; set; } = null!;

    /// <summary>
    ///     The symbol of the faction that this contract is for.
    /// </summary>
    public string FactionSymbol { get; set; } = null!;

    public ContractType Type { get; set; }

    public ContractTerms Terms { get; set; } = null!;

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