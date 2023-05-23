using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     The navigation information of the ship.
/// </summary>
public class ShipNav : IShipNav
{
    /// <summary>
    ///     The system symbol of the ship's current location.
    /// </summary>
    public string SystemSymbol { get; set; } = null!;

    /// <summary>
    ///     The waypoint symbol of the ship's current location, or if the ship is in-transit, the waypoint of the ship's
    ///     destination.
    /// </summary>
    public string WaypointSymbol { get; set; } = null!;

    public IShipNaveRoute Route { get; set; } = null!;

    public NavStatus Status { get; set; }

    public NavFlightMode FlightMode { get; set; } = NavFlightMode.Cruise;
}