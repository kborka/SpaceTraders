namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// The routing information for the ship's most recent transit or current location.
/// </summary>
public interface IShipNavRoute
{
    /// <summary>
    /// Gets or sets the destination of the ship's nav route.
    /// </summary>
    IShipNavRouteWaypoint Destination { get; set; }

    /// <summary>
    /// Gets or sets the departure of the ship's nav route.
    /// </summary>
    IShipNavRouteWaypoint Departure { get; set; }

    /// <summary>
    /// The date time of the ship's departure.
    /// </summary>
    DateTime DepartureTime { get; set; }

    /// <summary>
    /// The date time of the ship's arrival. If the ship is in-transit, this is the expected time of arrival.
    /// </summary>
    DateTime Arrival { get; set; }
}
