namespace SpaceTraders.Api.Models.Interfaces.Shipyards;

public interface IShipyardTransaction
{
    /// <summary>
    ///     The symbol of the waypoint where the transaction took place.
    /// </summary>
    string WaypointSymbol { get; set; }

    /// <summary>
    ///     The symbol of the ship that was purchased.
    /// </summary>
    string ShipSymbol { get; set; }

    /// <summary>
    ///     The price of the transaction.
    /// </summary>
    uint Price { get; set; }

    /// <summary>
    ///     The symbol of the agent that made the transaction.
    /// </summary>
    string AgentSymbol { get; set; }

    /// <summary>
    ///     The timestamp of the transaction.
    /// </summary>
    DateTime Timestamp { get; set; }
}