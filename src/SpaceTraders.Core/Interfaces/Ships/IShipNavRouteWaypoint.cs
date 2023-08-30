using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// An interface representing departure or destination information of a ship's nav route.
/// </summary>
public interface IShipNavRouteWaypoint : ISymbolModel, ICoordinateModel
{
    /// <summary>
    /// Gets or sets the waypoint's type.
    /// </summary>
    WaypointType Type { get; set; }

    /// <summary>
    /// Gets or sets the symbol of the system the waypoint is in.
    /// </summary>
    string SystemSymbol { get; set; }
}
