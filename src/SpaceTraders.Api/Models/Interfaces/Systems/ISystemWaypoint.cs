using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Systems;

public interface ISystemWaypoint : ICoordinateModel
{
    public WaypointType Type { get; set; }
}