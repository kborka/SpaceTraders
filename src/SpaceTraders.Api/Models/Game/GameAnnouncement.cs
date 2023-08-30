using SpaceTraders.Core.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

public class GameAnnouncement : IGameAnnouncement
{
    public string Title { get; set; } = null!;

    public string Body { get; set; } = null!;
}
