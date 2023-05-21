using System.Text.Json.Serialization;

namespace SpaceTraders.Api.Models.Game;

public class GameAnnouncement
{
    [JsonRequired]
    public string Title { get; set; } = null!;

    [JsonRequired]
    public string Body { get; set; } = null!;
}