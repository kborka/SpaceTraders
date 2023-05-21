using Prism.Mvvm;
using SpaceTraders.Api.Models.Game;
using SpaceTraders.ViewModels.Game;

namespace SpaceTraders.ViewModels;

public class StartViewModel : BindableBase
{
    public StartViewModel(GameStatus gameStatus)
    {

        GameStatus = new GameStatusViewModel(gameStatus);
    }

    public GameStatusViewModel GameStatus { get; }
}