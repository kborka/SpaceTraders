using Prism.Mvvm;
using SpaceTraders.Api.Models.Game;
using SpaceTraders.Api.Models.Interfaces.Game;

namespace SpaceTraders.ViewModels.Game;

public class LeaderboardValueViewModel : BindableBase
{

    public LeaderboardValueViewModel(ILeaderboardValue value)
    {
        AgentSymbol = value.AgentSymbol;
        LeaderValue = value.LeaderValue;
    }

    public string  AgentSymbol { get; }

    public uint LeaderValue { get; }
}