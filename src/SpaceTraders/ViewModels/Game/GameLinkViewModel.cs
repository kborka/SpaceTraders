using Prism.Mvvm;
using SpaceTraders.Core.Interfaces.Game;

namespace SpaceTraders.ViewModels.Game;

public class GameLinkViewModel : BindableBase
{
    public GameLinkViewModel(IGameLink link)
    {
        Name = link.Name;
        Url = link.Url;
    }

    public string Name { get; }

    public string Url { get; }
}