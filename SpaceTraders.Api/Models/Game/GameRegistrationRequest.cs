using SpaceTraders.Api.Models.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

public class GameRegistrationRequest : SymbolModelBase, IGameRegistrationRequest
{
    public string Faction { get; init; } = null!;

    public string Email { get; init; } = null!;
}