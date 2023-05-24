using Prism.Mvvm;
using SpaceTraders.Api.Models.Interfaces;
using SpaceTraders.Api.Services.Interfaces;

namespace SpaceTraders.ViewModels;

public class AgentViewModel : BindableBase
{
    private readonly IAgent _agent;
    public AgentViewModel(IAgentService agentService)
    {
    }

    //public bool HasData => _agent.IsCompletedSuccessfully;

    public string AccountId => _agent.AccountId;

    public string HeadQuarters => _agent.Headquarters;

    public string Symbol => _agent.Symbol;

    public int? Credits => _agent.Credits;
}