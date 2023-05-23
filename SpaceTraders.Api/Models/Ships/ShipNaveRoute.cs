using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     The routing information for the ship's most recent transit or current location.
/// </summary>
public class ShipNaveRoute : IShipNaveRoute
{
    public IShipNavRouteWaypoint Destination { get; set; } = null!;

    public IShipNavRouteWaypoint Departure { get; set; } = null!;

    /// <summary>
    ///     The date time of the ship's departure.
    /// </summary>
    public DateTime DepartureTime { get; set; }

    /// <summary>
    ///     The date time of the ship's arrival. If the ship is in-transit, this is the expected time of arrival.
    /// </summary>
    public DateTime Arrival { get; set; }
}