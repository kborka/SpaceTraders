namespace SpaceTraders.Core.Interfaces.Game;

public interface IGameLeaderboard
{
    IEnumerable<ILeaderboardValue> MostCredits { get; set; }

    IEnumerable<ILeaderboardValue> MostSubmittedCharts { get; set; }
}
