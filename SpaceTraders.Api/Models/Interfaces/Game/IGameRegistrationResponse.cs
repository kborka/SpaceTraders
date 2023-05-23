using SpaceTraders.Api.Models.Interfaces.Contracts;
using SpaceTraders.Api.Models.Interfaces.Factions;
using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Interfaces.Game;

public interface IGameRegistrationResponse
{
    string Token { get; set; }

    IAgent Agent { get; set; }

    IContract Contract { get; set; }

    IFaction Faction { get; set; }

    IShip Ship { get; set; }
}