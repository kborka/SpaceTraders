using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
/// The navigation information of the ship.
/// </summary>
public class ShipNav : IShipNav
{
    /// <inheritdoc />
    public string SystemSymbol { get; set; } = null!;

    /// <inheritdoc />
    public string WaypointSymbol { get; set; } = null!;

    /// <inheritdoc />
    public IShipNavRoute Route { get; set; } = null!;

    /// <inheritdoc />
    public NavStatus Status { get; set; }

    /// <inheritdoc />
    public NavFlightMode FlightMode { get; set; } = NavFlightMode.Cruise;
}
