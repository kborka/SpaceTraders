using System;
using System.Collections.Generic;

namespace SpaceTraders.Settings.Interfaces;

public interface IUserSettings
{
    IEnumerable<IRegisteredAgent>? RegisteredAgents { get; }

    DateTime? LastServerReset { get; set; }

    void AddNewAgent(IRegisteredAgent agent);

    void RemoveAgent(string agentSymbol);

    void RemoveAllAgents();
}