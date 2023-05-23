using SpaceTraders.Api.Models.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

public class GameLeaderboard : IGameLeaderboard
{
    public IEnumerable<Agent> MostCredits { get; set; } = null!;

    public IEnumerable<Agent> MostSubmittedCharts { get; set; } = null!;
}