using SpaceTraders.Api.Models.Interfaces;
using SpaceTraders.Api.Models.Interfaces.Contracts;
using SpaceTraders.Api.Models.Interfaces.Factions;
using SpaceTraders.Api.Models.Interfaces.Game;
using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Game;

public class GameRegistrationResponse : IGameRegistrationResponse
{
    public string Token { get; set; } = null!;

    public IAgent Agent { get; set; } = null!;

    public IContract Contract { get; set; } = null!;

    public IFaction Faction { get; set; } = null!;

    public IShip Ship { get; set; } = null!;
}