using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

public class ShipNavRouteWaypoint : SymbolModelBase, IShipNavRouteWaypoint
{
    public WaypointType Type { get; set; }

    public string SystemSymbol { get; set; } = null!;

    public int X { get; set; }

    public int Y { get; set; }
}