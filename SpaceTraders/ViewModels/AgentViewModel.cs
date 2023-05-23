using System.ComponentModel;
using Prism.Mvvm;
using SpaceTraders.Api.Models.Interfaces;
using SpaceTraders.Api.Services.Interfaces;
using SpaceTraders.ComponentModel;
using SpaceTraders.ComponentModel.Interfaces;

namespace SpaceTraders.ViewModels;

public class AgentViewModel : BindableBase
{
    private readonly NotifyTaskCompletion<IAgent?> _agent;
    public AgentViewModel(IAgentService agentService)
    {
        _agent = new NotifyTaskCompletion<IAgent?>(agentService.GetAgent());
        _agent.PropertyChanged += AgentTask_PropertyChanged;
    }

    public bool HasData => _agent.IsCompletedSuccessfully;

    public string? AccountId => _agent.Result?.AccountId;

    public string? HeadQuarters => _agent.Result?.Headquarters;

    public string? Symbol => _agent.Result?.Symbol;

    public int? Credits => _agent.Result?.Credits;

    private void AgentTask_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(INotifyTaskCompletion.IsCompletedSuccessfully):
                this.RaisePropertyChanged(nameof(HasData));
                this.RaisePropertyChanged(nameof(Symbol));
                this.RaisePropertyChanged(nameof(HeadQuarters));
                this.RaisePropertyChanged(nameof(AccountId));
                this.RaisePropertyChanged(nameof(Credits));
                break;
        }

    }
}