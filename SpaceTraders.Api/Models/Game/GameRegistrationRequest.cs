namespace SpaceTraders.Api.Models.Game;

public class GameRegistrationRequest : SymbolModelBase
{
    public string Faction { get; init; } = null!;

    public string Email { get; init; } = null!;
}