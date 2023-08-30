using System.Text.Json.Serialization;

namespace SpaceTraders.Api.Models.Game;

public class LeaderboardCredits : LeaderboardValueBase
{
    [JsonPropertyName("credits")] public override uint LeaderValue { get; set; }
}
