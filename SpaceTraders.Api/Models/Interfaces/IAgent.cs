namespace SpaceTraders.Api.Models.Interfaces;

public interface IAgent : ISymbolModel
{
    string AccountId { get; set; }

    /// <summary>
    ///     The headquarters of the agent.
    /// </summary>
    string Headquarters { get; set; }

    /// <summary>
    ///     The number of credits the agent has available.
    ///     Credits can be negative if funds have been overdrawn.
    /// </summary>
    long Credits { get; set; }

    /// <summary>
    ///     The faction the agent started with.
    /// </summary>
    string StartingFaction { get; set; }
}