using System;
using System.Collections.Generic;
using Config.Net;

namespace SpaceTraders.Interfaces;

public interface IConnectionSettings
{
    IEnumerable<IAgentInfo> ActiveAgents { get; set; }

    DateTime? LastServerReset { get; set; }
}