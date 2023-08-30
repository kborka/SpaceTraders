using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Systems;

namespace SpaceTraders.Api.Models.Systems;

public class SystemWaypoint : CoordinateSymbolModelBase, ISystemWaypoint
{
    /// <inheritdoc />
    public WaypointType Type { get; set; }
}
