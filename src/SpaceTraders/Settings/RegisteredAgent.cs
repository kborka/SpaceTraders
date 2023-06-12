using System.Text.Json.Serialization;
using SpaceTraders.Settings.Interfaces;

namespace SpaceTraders.Settings;

public class RegisteredAgent : IRegisteredAgent
{
    [JsonRequired] public string Token { get; set; }

    [JsonRequired] public string AgentSymbol { get; set; }

    [JsonRequired] public long Credits { get; set; }

    public RegisteredAgent(string token, string agentSymbol, long credits)
    {
        Token = token;
        AgentSymbol = agentSymbol;
        Credits = credits;
    }
}