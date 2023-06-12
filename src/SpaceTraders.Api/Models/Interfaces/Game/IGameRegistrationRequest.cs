using System.Text.Json.Serialization;
using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Game;

namespace SpaceTraders.Api.Models.Interfaces.Game;

[JsonPolymorphic]
[JsonDerivedType(typeof(GameRegistrationRequest))]
public interface IGameRegistrationRequest : ISymbolModel
{
    StartingFactionType Faction { get; init; }

    string Email { get; init; }
}