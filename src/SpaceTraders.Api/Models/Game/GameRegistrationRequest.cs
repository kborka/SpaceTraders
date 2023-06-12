using System.Text.Json.Serialization;
using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

public class GameRegistrationRequest : SymbolModelBase, IGameRegistrationRequest
{
    [JsonRequired]
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public StartingFactionType Faction { get; init; }

    [JsonRequired]
    public string Email { get; init; } = null!;
}