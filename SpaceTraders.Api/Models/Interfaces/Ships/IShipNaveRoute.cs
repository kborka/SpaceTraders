namespace SpaceTraders.Api.Models.Interfaces.Ships;

/// <summary>
///     The routing information for the ship's most recent transit or current location.
/// </summary>
public interface IShipNaveRoute
{
    IShipNavRouteWaypoint Destination { get; set; }

    IShipNavRouteWaypoint Departure { get; set; }

    /// <summary>
    ///     The date time of the ship's departure.
    /// </summary>
    DateTime DepartureTime { get; set; }

    /// <summary>
    ///     The date time of the ship's arrival. If the ship is in-transit, this is the expected time of arrival.
    /// </summary>
    DateTime Arrival { get; set; }
}