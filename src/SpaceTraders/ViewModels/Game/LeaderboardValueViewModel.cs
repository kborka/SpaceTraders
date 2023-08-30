using Prism.Mvvm;
using SpaceTraders.Core.Interfaces.Game;

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