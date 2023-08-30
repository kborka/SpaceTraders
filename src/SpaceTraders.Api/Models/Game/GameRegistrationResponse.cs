using SpaceTraders.Core.Interfaces.Agents;
using SpaceTraders.Core.Interfaces.Contracts;
using SpaceTraders.Core.Interfaces.Factions;
using SpaceTraders.Core.Interfaces.Game;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Game;

public class GameRegistrationResponse : IGameRegistrationResponse
{
    public string Token { get; set; } = null!;

    public IAgent Agent { get; set; } = null!;

    public IContract Contract { get; set; } = null!;

    public IFaction Faction { get; set; } = null!;

    public IShip Ship { get; set; } = null!;
}
