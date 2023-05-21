using System;
using Config.Net;

namespace SpaceTraders.Interfaces;

public interface IConnectionSettings
{
    string? AgentAuthToken { get; set; }

    DateTime? LastServerReset { get; set; }
}