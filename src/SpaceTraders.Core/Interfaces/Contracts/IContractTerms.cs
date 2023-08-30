namespace SpaceTraders.Core.Interfaces.Contracts;

public interface IContractTerms
{
    /// <summary>
    /// The deadline for the contract.
    /// </summary>
    DateTime Deadline { get; set; }

    /// <summary>
    /// Payment information for this contract.
    /// </summary>
    IContractPayment Payment { get; set; }

    /// <summary>
    /// The cargo that needs to be delivered to fulfill the contract.
    /// </summary>
    IEnumerable<IContractDeliverGood>? Deliver { get; set; }
}
