﻿using System.Text.Json.Serialization;
using SpaceTraders.Core.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

/// <summary>
/// Represents the current game status.
/// </summary>
public class GameStatus : IGameStatus
{
    public GameStats Stats { get; set; } = null!;

    public GameLeaderboard Leaderboards { get; set; } = null!;

    [JsonPropertyName("serverResets")] public GameServerReset NextServerReset { get; set; } = null!;

    public IEnumerable<GameAnnouncement> Announcements { get; set; } = null!;

    public IEnumerable<GameLink> Links { get; set; } = null!;
    public string Status { get; set; } = null!;

    public string Version { get; set; } = null!;

    [JsonPropertyName("resetDate")] public DateTime LastResetDate { get; set; }

    public string Description { get; set; } = null!;

    IGameStats IGameStatus.Stats
    {
        get => Stats;
        set
        {
            if (value is not GameStats stats)
            {
                throw new InvalidCastException("Invalid IGameStats type: Expected GameStats.");
            }

            Stats = stats;
        }
    }

    IGameLeaderboard IGameStatus.Leaderboards
    {
        get => Leaderboards;
        set
        {
            if (value is not GameLeaderboard leaderboards)
            {
                throw new InvalidCastException("Invalid IGameLeaderboard type: Expected GameLeaderboard");
            }

            Leaderboards = leaderboards;
        }
    }

    IGameServerReset IGameStatus.NextServerReset
    {
        get => NextServerReset;
        set
        {
            if (value is not GameServerReset serverReset)
            {
                throw new InvalidCastException("Invalid IGameServerReset type: Expected GameServerReset");
            }

            NextServerReset = serverReset;
        }
    }

    IEnumerable<IGameAnnouncement> IGameStatus.Announcements
    {
        get => Announcements;
        set
        {
            if (value is not IEnumerable<GameAnnouncement> announcements)
            {
                throw new InvalidCastException(
                                               "Invalid IEnumerable<IGameAnnouncement> type: Expected IEnumerable<GameAnnouncement>");
            }

            Announcements = announcements;
        }
    }

    IEnumerable<IGameLink> IGameStatus.Links
    {
        get => Links;
        set
        {
            if (value is not IEnumerable<GameLink> links)
            {
                throw new InvalidCastException("Invalid IEnumerable<IGameLink> type: Expected IEnumerable<GameLink>");
            }

            Links = links;
        }
    }
}
