using System.Text.Json.Serialization;
using SpaceTraders.Api.Models.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

public abstract class LeaderboardValueBase : ILeaderboardValue
{
    public string AgentSymbol { get; set; }

    public abstract uint LeaderValue { get; set; }
}