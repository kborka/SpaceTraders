using System.Text.Json.Serialization;
using SpaceTraders.Api.Models.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

public class GameServerReset : IGameServerReset
{
    [JsonPropertyName("next")]
    public DateTime NextReset { get; set; }

    public string Frequency { get; set; } = null!;
}