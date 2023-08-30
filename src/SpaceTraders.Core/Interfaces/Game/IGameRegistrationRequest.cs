using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Game;

public interface IGameRegistrationRequest : ISymbolModel
{
    string Faction { get; init; }

    string Email { get; init; }
}
