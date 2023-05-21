using System.Text.Json.Serialization;

namespace SpaceTraders.Api.Models.Game;

public class GameStats
{
    [JsonRequired]
    [JsonPropertyName("agents")]
    public uint AgentCount { get; set; }

    [JsonRequired]
    [JsonPropertyName("ships")]
    public uint ShipCount { get; set; }

    [JsonRequired]
    [JsonPropertyName("systems")]
    public uint SystemCount { get; set; }

    [JsonRequired]
    [JsonPropertyName("waypoints")]
    public uint WaypointCount { get; set; }
}