namespace SpaceTraders.Core.Interfaces.Game;

public interface ILeaderboardValue
{
    string AgentSymbol { get; set; }

    uint LeaderValue { get; set; }
}
