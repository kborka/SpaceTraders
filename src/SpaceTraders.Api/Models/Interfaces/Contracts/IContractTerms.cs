namespace SpaceTraders.Api.Models.Interfaces.Contracts;

public interface IContractTerms
{
    /// <summary>
    ///     The deadline for the contract.
    /// </summary>
    DateTime Deadline { get; set; }

    IContractPayment Payment { get; set; }

    IEnumerable<IContractDeliverGood>? Deliver { get; set; }
}