using System.Text.Json.Serialization;

namespace SpaceTraders.Api.Models.Game;

public class GameLink
{
    [JsonRequired]
    public string Name { get; set; } = null!;

    [JsonRequired]
    public string Url { get; set; } = null!;
}