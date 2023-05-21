using System.Text.Json.Serialization;

namespace SpaceTraders.Api.Models.Game;

public class GameServerReset
{
    [JsonRequired]
    [JsonPropertyName("next")]
    public string NextReset { get; set; } = null!;

    [JsonRequired]
    public string Frequency { get; set; } = null!;
}