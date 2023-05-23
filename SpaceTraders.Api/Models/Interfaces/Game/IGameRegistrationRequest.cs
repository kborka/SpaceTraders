using System.Text.Json.Serialization;

namespace SpaceTraders.Api.Models.Interfaces.Game;

public interface IGameRegistrationRequest : ISymbolModel
{
    [JsonRequired]
    string Faction { get; init; }

    [JsonRequired]
    string Email { get; init; }
}