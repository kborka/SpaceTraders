using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

public class ShipNavRouteWaypoint : SymbolModelBase, IShipNavRouteWaypoint
{
    /// <inheritdoc />
    public WaypointType Type { get; set; }

    /// <inheritdoc />
    public string SystemSymbol { get; set; } = null!;

    /// <inheritdoc />
    public int X { get; set; }

    /// <inheritdoc />
    public int Y { get; set; }
}
