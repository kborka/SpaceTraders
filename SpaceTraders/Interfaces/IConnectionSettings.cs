using System;
using System.Collections.Generic;
using Config.Net;

namespace SpaceTraders.Interfaces;

public interface IConnectionSettings
{
    string? AgentToken { get; set; }

    string? AgentSymbol { get; set; }

    int? AgentCredits { get; set; }

    DateTime? LastServerReset { get; set; }
}