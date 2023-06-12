using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Mvvm;
using SpaceTraders.Api.Models.Interfaces.Game;
using SpaceTraders.Utilities;

namespace SpaceTraders.ViewModels;

public class MainViewModel : BindableBase
{
    private AgentViewModel _agentViewModel;

    public MainViewModel()
    {
        AgentViewModel = AppNexus.ApplicationContainer.Resolve<AgentViewModel>();
        InitializeViewModelsAsync();
    }

    public MainViewModel(IGameRegistrationResponse registrationInfo) : this()
    {
        AgentViewModel.Initialize(registrationInfo.Agent);
    }

    public AgentViewModel AgentViewModel
    {
        get => _agentViewModel;
        set => SetProperty(ref _agentViewModel, value);
    }

    private void InitializeViewModelsAsync()
    {
        var task = Task.Run<bool>(async () => await AgentViewModel.Initialization);
    }
}