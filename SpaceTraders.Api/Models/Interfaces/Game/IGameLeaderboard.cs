namespace SpaceTraders.Api.Models.Interfaces.Game;

public interface IGameLeaderboard
{
    IEnumerable<Agent> MostCredits { get; set; }

    IEnumerable<Agent> MostSubmittedCharts { get; set; }
}