using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Agents;

public interface IAgent : ISymbolModel
{
    /// <summary>
    /// Account ID that is tied to this agent. Only included in user's own agent.
    /// </summary>
    string? AccountId { get; set; }

    /// <summary>
    /// The headquarters of the agent.
    /// </summary>
    string Headquarters { get; set; }

    /// <summary>
    /// The number of credits the agent has available.
    /// Credits can be negative if funds have been overdrawn.
    /// </summary>
    long Credits { get; set; }

    /// <summary>
    /// The faction the agent started with.
    /// </summary>
    string StartingFaction { get; set; }

    /// <summary>
    /// The number of ships owned by the agent.
    /// </summary>
    int? ShipCount { get; set; }
}
