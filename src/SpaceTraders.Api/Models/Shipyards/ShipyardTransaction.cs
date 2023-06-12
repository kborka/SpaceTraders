using SpaceTraders.Api.Models.Interfaces.Shipyards;

namespace SpaceTraders.Api.Models.Shipyards;

public class ShipyardTransaction : IShipyardTransaction
{
    /// <summary>
    ///     The symbol of the waypoint where the transaction took place.
    /// </summary>
    public string WaypointSymbol { get; set; } = null!;

    /// <summary>
    ///     The symbol of the ship that was purchased.
    /// </summary>
    public string ShipSymbol { get; set; } = null!;

    /// <summary>
    ///     The price of the transaction.
    /// </summary>
    public uint Price { get; set; }

    /// <summary>
    ///     The symbol of the agent that made the transaction.
    /// </summary>
    public string AgentSymbol { get; set; } = null!;

    /// <summary>
    ///     The timestamp of the transaction.
    /// </summary>
    public DateTime Timestamp { get; set; }
}