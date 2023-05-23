using SpaceTraders.Api.Models.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

public class GameLink : IGameLink
{
    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;
}