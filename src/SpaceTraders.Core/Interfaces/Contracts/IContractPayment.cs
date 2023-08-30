namespace SpaceTraders.Core.Interfaces.Contracts;

public interface IContractPayment
{
    /// <summary>
    /// The amount of credits received up front for accepting the contract.
    /// </summary>
    int OnAccepted { get; set; }

    /// <summary>
    /// The amount of credits received when the contract is fulfilled.
    /// </summary>
    int OnFulfilled { get; set; }
}
