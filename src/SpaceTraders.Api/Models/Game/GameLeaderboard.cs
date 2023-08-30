using SpaceTraders.Core.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

public class GameLeaderboard : IGameLeaderboard
{
    public IEnumerable<LeaderboardCredits> MostCredits { get; set; } = null!;
    public IEnumerable<LeaderboardSubmittedCharts> MostSubmittedCharts { get; set; } = null!;

    IEnumerable<ILeaderboardValue> IGameLeaderboard.MostCredits
    {
        get => MostCredits;
        set
        {
            if (value is not IEnumerable<LeaderboardCredits> mostCredits)
            {
                throw new InvalidCastException(
                                               "Invalid IEnumerable<ILeaderboardValue> type: Expected <IEnumerableLeaderboardCredits>");
            }

            MostCredits = mostCredits;
        }
    }


    IEnumerable<ILeaderboardValue> IGameLeaderboard.MostSubmittedCharts
    {
        get => MostSubmittedCharts;
        set
        {
            if (value is not IEnumerable<LeaderboardSubmittedCharts> submittedCharts)
            {
                throw new InvalidCastException(
                                               "Invalid IEnumerable<ILeaderboardValue> type: Expected <IEnumerableLeaderboardSubmittedCharts>");
            }

            MostSubmittedCharts = submittedCharts;
        }
    }
}
