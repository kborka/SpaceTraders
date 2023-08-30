using System.Threading.Tasks;
using Prism.Mvvm;
using SpaceTraders.Api.Services.Interfaces;
using SpaceTraders.Core.Interfaces.Agents;
using SpaceTraders.Interfaces;

namespace SpaceTraders.ViewModels.Agents;

public class AgentViewModel : BindableBase
{
    private readonly IAgentService _agentService;
    private bool _hasData;
    private IAgent? _agent;

    public AgentViewModel(IAgentService agentService)
    {
        _agentService = agentService;
        Initialization = InitializeAsync();
    }

    public Task<bool> Initialization { get; }

    public bool HasData
    {
        get => _hasData;
        set => SetProperty(ref _hasData, value);
    }

    public string? AccountId => _agent?.AccountId;

    public string? HeadQuarters => _agent?.Headquarters;

    public string? Symbol => _agent?.Symbol;

    public long? Credits => _agent?.Credits;

    public void Initialize(IAgent agent)
    {
        _agent = agent;
        HasData = true;
    }

    private async Task<bool> InitializeAsync()
    {
        _agent = await _agentService.GetAgent();
        HasData = _agent is not null;
        return _agent is not null;
    }
}
