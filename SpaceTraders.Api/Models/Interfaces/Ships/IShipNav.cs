using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Ships;

/// <summary>
///     The navigation information of the ship.
/// </summary>
public interface IShipNav
{
    /// <summary>
    ///     The system symbol of the ship's current location.
    /// </summary>
    string SystemSymbol { get; set; }

    /// <summary>
    ///     The waypoint symbol of the ship's current location, or if the ship is in-transit, the waypoint of the ship's
    ///     destination.
    /// </summary>
    string WaypointSymbol { get; set; }

    IShipNaveRoute Route { get; set; }

    NavStatus Status { get; set; }

    NavFlightMode FlightMode { get; set; }
}