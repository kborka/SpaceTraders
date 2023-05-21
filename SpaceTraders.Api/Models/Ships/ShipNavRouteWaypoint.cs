using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Ships;

public class ShipNavRouteWaypoint : SymbolModelBase
{
    public WaypointType Type { get; set; }

    public string SystemSymbol { get; set; } = null!;

    public int X { get; set; }

    public int Y { get; set; }
}