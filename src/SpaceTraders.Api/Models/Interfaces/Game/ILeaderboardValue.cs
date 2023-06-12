namespace SpaceTraders.Api.Models.Interfaces.Game;

public interface ILeaderboardValue
{
    string AgentSymbol { get; set; }

    uint LeaderValue { get; set; }
}