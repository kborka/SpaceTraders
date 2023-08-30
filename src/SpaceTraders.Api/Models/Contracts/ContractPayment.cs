using SpaceTraders.Core.Interfaces.Contracts;

namespace SpaceTraders.Api.Models.Contracts;

public class ContractPayment : IContractPayment
{
    /// <summary>
    /// The amount of credits received up front for accepting the contract.
    /// </summary>
    public int OnAccepted { get; set; }

    /// <summary>
    /// The amount of credits received when the contract is fulfilled.
    /// </summary>
    public int OnFulfilled { get; set; }
}
