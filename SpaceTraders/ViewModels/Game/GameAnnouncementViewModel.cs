using Prism.Mvvm;
using SpaceTraders.Api.Models.Interfaces.Game;

namespace SpaceTraders.ViewModels.Game;

public class GameAnnouncementViewModel : BindableBase
{
    public GameAnnouncementViewModel(IGameAnnouncement announcement)
    {
        Title = announcement.Title;
        Body = announcement.Body;
    }

    public string Title { get; }

    public string Body { get; }
}