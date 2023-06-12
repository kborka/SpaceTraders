namespace SpaceTraders.Api.Models.Interfaces.Game;

public interface IGameStats
{
    uint AgentCount { get; set; }

    uint ShipCount { get; set; }

    uint SystemCount { get; set; }

    uint WaypointCount { get; set; }
}