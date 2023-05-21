using Prism.Mvvm;
using SpaceTraders.Api.Models.Game;

namespace SpaceTraders.ViewModels.Game;

public class GameLinkViewModel : BindableBase
{
    public GameLinkViewModel(GameLink link)
    {
        Name = link.Name;
        Url = link.Url;
    }

    public string Name { get; }

    public string Url { get; }
}