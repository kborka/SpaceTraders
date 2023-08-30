namespace SpaceTraders.Core.Interfaces.Core;

public interface ITransactionModel
{
    /// <summary>
    /// Gets or sets the waypoint where the transaction took place.
    /// </summary>
    string WaypointSymbol { get; set; }

    /// <summary>
    /// Gets or sets the symbol of the ship that made the transaction.
    /// </summary>
    string ShipSymbol { get; set; }

    /// <summary>
    /// Gets or sets the timestamp of the transaction.
    /// </summary>
    DateTime Timestamp { get; set; }
}
