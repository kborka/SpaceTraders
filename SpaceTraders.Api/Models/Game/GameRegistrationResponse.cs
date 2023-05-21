using SpaceTraders.Api.Models.Contracts;
using SpaceTraders.Api.Models.Factions.Faction;
using SpaceTraders.Api.Models.Ships;

namespace SpaceTraders.Api.Models.Game;

public class GameRegistrationResponse
{
    public string Token { get; set; } = null!;

    public Agent Agent { get; set; } = null!;

    public Contract Contract { get; set; } = null!;

    public Faction Faction { get; set; } = null!;

    public Ship Ship { get; set; } = null!;
}