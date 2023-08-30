using System.Text.Json.Serialization;
using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

public class GameRegistrationRequest : SymbolModelBase, IGameRegistrationRequest
{
    [JsonRequired]
    public string Faction { get; init; } = null!;

    [JsonRequired] public string Email { get; init; } = null!;
}
