using SpaceTraders.Core.Enums;

namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// The navigation information of the ship.
/// </summary>
public interface IShipNav
{
    /// <summary>
    /// The system symbol of the ship's current location.
    /// </summary>
    string SystemSymbol { get; set; }

    /// <summary>
    /// The waypoint symbol of the ship's current location, or if the ship is in-transit, the waypoint of the ship's
    /// destination.
    /// </summary>
    string WaypointSymbol { get; set; }

    /// <summary>
    /// Gets or sets the routing information of the ship's most recent transit or current location.
    /// </summary>
    IShipNavRoute Route { get; set; }

    /// <summary>
    /// Gets or sets the current status of the ship.
    /// </summary>
    NavStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the ship's speed when travelling between waypoints or systems.
    /// </summary>
    NavFlightMode FlightMode { get; set; }
}
