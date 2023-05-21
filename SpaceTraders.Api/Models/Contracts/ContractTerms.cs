namespace SpaceTraders.Api.Models.Contracts;

public class ContractTerms
{
    /// <summary>
    ///     The deadline for the contract.
    /// </summary>
    public DateTime Deadline { get; set; }

    public ContractPayment Payment { get; set; } = null!;

    public IEnumerable<ContractDeliverGood>? Deliver { get; set; }
}