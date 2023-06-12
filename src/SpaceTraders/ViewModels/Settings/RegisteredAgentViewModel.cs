using Prism.Mvvm;
using SpaceTraders.Settings.Interfaces;

namespace SpaceTraders.ViewModels.Settings;

public class RegisteredAgentViewModel : BindableBase
{
    public RegisteredAgentViewModel(IRegisteredAgent agent)
    {
        AgentSymbol = agent.AgentSymbol;
        Token = agent.Token;
        Credits = agent.Credits;
    }

    public string AgentSymbol { get; }

    public string Token { get; }

    public long Credits { get; }
}