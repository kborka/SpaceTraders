using Prism.Mvvm;
using SpaceTraders.Api.Models.Interfaces.Game;

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