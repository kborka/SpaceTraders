using Prism.Mvvm;
using SpaceTraders.Api.Models.Game;

namespace SpaceTraders.ViewModels.Game;

public class GameAnnouncementViewModel : BindableBase
{
    public GameAnnouncementViewModel(GameAnnouncement announcement)
    {
        Title = announcement.Title;
        Body = announcement.Body;
    }

    public string Title { get; }

    public string Body { get; }
}