using System.Text.Json.Serialization;

namespace SpaceTraders.Api.Models.Game;

/// <summary>
///     Represents the current game status.
/// </summary>
public class GameStatus
{
    [JsonRequired]
    public string Status { get; set; } = null!;

    [JsonRequired]
    public string Version { get; set; } = null!;

    [JsonRequired]
    [JsonPropertyName("resetDate")]
    public DateTime LastResetDate { get; set; }

    [JsonRequired]
    public string Description { get; set; } = null!;

    [JsonRequired]
    public GameStats Stats { get; set; } = null!;

    [JsonRequired]
    public GameLeaderBoard Leaderboards { get; set; } = null!;

    [JsonRequired]
    [JsonPropertyName("serverResets")]
    public GameServerReset NextServerReset { get; set; } = null!;

    [JsonRequired]
    public IEnumerable<GameAnnouncement> Announcements { get; set; } = null!;

    [JsonRequired]
    public IEnumerable<GameLink> Links { get; set; } = null!;
}