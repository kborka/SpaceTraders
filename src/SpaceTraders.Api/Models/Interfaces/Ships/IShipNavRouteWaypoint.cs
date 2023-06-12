using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Ships;

public interface IShipNavRouteWaypoint : ISymbolModel
{
    WaypointType Type { get; set; }

    string SystemSymbol { get; set; }

    int X { get; set; }

    int Y { get; set; }
}