using Prism.Mvvm;
using SpaceTraders.Api.Models.Interfaces.Game;
using SpaceTraders.ViewModels.Game;

namespace SpaceTraders.ViewModels;

public class StartViewModel : BindableBase
{
    public StartViewModel(IGameStatus gameStatus)
    {

        GameStatus = new GameStatusViewModel(gameStatus);
    }

    public GameStatusViewModel GameStatus { get; }
}