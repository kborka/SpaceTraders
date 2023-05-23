using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Systems;

namespace SpaceTraders.Api.Models.Systems;

public class SystemWaypoint : CoordinateModelBase, ISystemWaypoint
{
    public WaypointType Type { get; set; }
}