namespace SpaceTraders.Api.Models.Interfaces.Game;

/// <summary>
///     Represents the current game status.
/// </summary>
public interface IGameStatus
{
    string Status { get; set; }

    string Version { get; set; }

    DateTime LastResetDate { get; set; }

    string Description { get; set; }

    IGameStats Stats { get; set; }

    IGameLeaderboard Leaderboards { get; set; }

    IGameServerReset NextServerReset { get; set; }

    IEnumerable<IGameAnnouncement> Announcements { get; set; }

    IEnumerable<IGameLink> Links { get; set; }
}