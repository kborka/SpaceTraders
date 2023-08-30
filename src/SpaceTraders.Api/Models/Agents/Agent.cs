using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Agents;

namespace SpaceTraders.Api.Models.Agents;

public class Agent : SymbolModelBase, IAgent
{
    /// <inheritdoc />
    public string? AccountId { get; set; }

    /// <inheritdoc />
    public string Headquarters { get; set; } = null!;

    /// <inheritdoc />
    public long Credits { get; set; }

    /// <inheritdoc />
    public string StartingFaction { get; set; } = null!;

    /// <inheritdoc />
    public int? ShipCount { get; set; }
}
