using System.Text.Json.Serialization;
using SpaceTraders.Core.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

public class GameServerReset : IGameServerReset
{
    [JsonPropertyName("next")] public DateTime NextReset { get; set; }

    public string Frequency { get; set; } = null!;
}
