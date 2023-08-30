using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
/// The routing information for the ship's most recent transit or current location.
/// </summary>
public class ShipNavRoute : IShipNavRoute
{
    /// <inheritdoc />
    public IShipNavRouteWaypoint Destination { get; set; } = null!;

    /// <inheritdoc />
    public IShipNavRouteWaypoint Departure { get; set; } = null!;

    /// <inheritdoc />
    public DateTime DepartureTime { get; set; }

    /// <inheritdoc />
    public DateTime Arrival { get; set; }
}
