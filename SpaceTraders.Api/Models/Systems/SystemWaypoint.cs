using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Systems;

public class SystemWaypoint
{
    public WaypointType Type { get; set; }

    public int X { get; set; }

    public int Y { get; set; }
}