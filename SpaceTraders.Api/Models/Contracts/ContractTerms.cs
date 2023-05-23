using SpaceTraders.Api.Models.Interfaces.Contracts;

namespace SpaceTraders.Api.Models.Contracts;

public class ContractTerms : IContractTerms
{
    /// <summary>
    ///     The deadline for the contract.
    /// </summary>
    public DateTime Deadline { get; set; }

    public IContractPayment Payment { get; set; } = null!;

    public IEnumerable<IContractDeliverGood>? Deliver { get; set; }
}