using System.Collections.Generic;
using System.Collections.ObjectModel;
using Prism.Mvvm;
using SpaceTraders.Api.Models.Interfaces.Game;

namespace SpaceTraders.ViewModels.Game;

public class GameLeaderboardViewModel : BindableBase
{
    public GameLeaderboardViewModel(IGameLeaderboard leaderboard)
    {
        MostCredits = new ObservableCollection<LeaderboardValueViewModel>();
        foreach (var leader in leaderboard.MostCredits)
        {
            MostCredits.Add(new LeaderboardValueViewModel(leader));
        }

        MostSubmittedCharts = new ObservableCollection<LeaderboardValueViewModel>();
        foreach (var leader in leaderboard.MostSubmittedCharts)
        {
            MostSubmittedCharts.Add(new LeaderboardValueViewModel(leader));
        }
    }

    public ObservableCollection<LeaderboardValueViewModel> MostCredits { get; }

    public ObservableCollection<LeaderboardValueViewModel> MostSubmittedCharts { get; }
}