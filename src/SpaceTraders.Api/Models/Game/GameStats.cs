using System.Text.Json.Serialization;
using SpaceTraders.Core.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

public class GameStats : IGameStats
{
    [JsonPropertyName("agents")] public uint AgentCount { get; set; }

    [JsonPropertyName("ships")] public uint ShipCount { get; set; }

    [JsonPropertyName("systems")] public uint SystemCount { get; set; }

    [JsonPropertyName("waypoints")] public uint WaypointCount { get; set; }
}
