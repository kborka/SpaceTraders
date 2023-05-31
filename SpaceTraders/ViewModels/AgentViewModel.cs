using System.Threading.Tasks;
using Prism.Mvvm;
using SpaceTraders.Api.Models.Interfaces;
using SpaceTraders.Api.Models.Interfaces.Game;
using SpaceTraders.Api.Services.Interfaces;
using SpaceTraders.Interfaces;

namespace SpaceTraders.ViewModels;

public class AgentViewModel : BindableBase, IAsyncInitialization
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

    public int? Credits => _agent?.Credits;

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