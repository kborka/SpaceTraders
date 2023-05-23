using SpaceTraders.Api.Models.Interfaces;

namespace SpaceTraders.Api.Models;

public class Agent : SymbolModelBase, IAgent
{
    public string AccountId { get; set; } = null!;

    /// <summary>
    ///     The headquarters of the agent.
    /// </summary>
    public string Headquarters { get; set; } = null!;

    /// <summary>
    ///     The number of credits the agent has available.
    ///     Credits can be negative if funds have been overdrawn.
    /// </summary>
    public int Credits { get; set; }

    /// <summary>
    ///     The faction the agent started with.
    /// </summary>
    public string StartingFaction { get; set; } = null!;
}