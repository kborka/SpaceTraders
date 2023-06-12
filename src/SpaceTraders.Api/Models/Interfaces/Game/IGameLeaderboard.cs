namespace SpaceTraders.Api.Models.Interfaces.Game;

public interface IGameLeaderboard
{
    IEnumerable<ILeaderboardValue> MostCredits { get; set; }

    IEnumerable<ILeaderboardValue> MostSubmittedCharts { get; set; }
}