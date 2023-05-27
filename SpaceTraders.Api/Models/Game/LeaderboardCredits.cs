using System.Text.Json.Serialization;
using SpaceTraders.Api.Models.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

public class LeaderboardCredits : LeaderboardValueBase
{
    [JsonPropertyName("credits")]
    public override uint LeaderValue { get; set; }
}