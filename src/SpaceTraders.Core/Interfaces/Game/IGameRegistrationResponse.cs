using SpaceTraders.Core.Interfaces.Agents;
using SpaceTraders.Core.Interfaces.Contracts;
using SpaceTraders.Core.Interfaces.Factions;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Core.Interfaces.Game;

public interface IGameRegistrationResponse
{
    string Token { get; set; }

    IAgent Agent { get; set; }

    IContract Contract { get; set; }

    IFaction Faction { get; set; }

    IShip Ship { get; set; }
}
