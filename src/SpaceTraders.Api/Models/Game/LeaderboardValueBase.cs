﻿using SpaceTraders.Core.Interfaces.Game;

namespace SpaceTraders.Api.Models.Game;

public abstract class LeaderboardValueBase : ILeaderboardValue
{
    public string AgentSymbol { get; set; } = null!;

    public abstract uint LeaderValue { get; set; }
}
