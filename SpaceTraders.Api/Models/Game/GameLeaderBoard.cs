using System.Text.Json.Serialization;

namespace SpaceTraders.Api.Models.Game;

public class GameLeaderBoard
{
    [JsonRequired]
    public IEnumerable<Agent> MostCredits { get; set; } = null!;

    [JsonRequired]
    public IEnumerable<Agent> MostSubmittedCharts { get; set; } = null!;
}