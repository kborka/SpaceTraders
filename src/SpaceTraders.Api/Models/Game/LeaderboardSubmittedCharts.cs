using System.Text.Json.Serialization;

namespace SpaceTraders.Api.Models.Game;

public class LeaderboardSubmittedCharts : LeaderboardValueBase
{
    [JsonPropertyName("chartCount")] public override uint LeaderValue { get; set; }
}
