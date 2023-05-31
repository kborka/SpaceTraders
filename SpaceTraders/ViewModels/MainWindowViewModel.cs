using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Ioc;
using Prism.Mvvm;
using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Game;
using SpaceTraders.ComponentModel;
using SpaceTraders.Utilities;

namespace SpaceTraders.ViewModels;

public class MainWindowViewModel : BindableBase
{
    private bool _dataLoaded;
    private BindableBase? _selectedViewModel;

    public MainWindowViewModel()
    {
        InitializeCommand = new AsyncCommand(Initialize);
    }

    public ICommand InitializeCommand { get; }

    public bool DataLoaded
    {
        get => _dataLoaded;
        set => SetProperty(ref _dataLoaded, value);
    }

    public BindableBase? SelectedViewModel
    {
        get => _selectedViewModel;
        private set => this.SetProperty(ref _selectedViewModel, value);
    }

    private async Task Initialize()
    {
        var startVm = AppNexus.ApplicationContainer.Resolve<StartViewModel>();
        await startVm.Initialization;
        startVm.NewAgentRegistered += StartView_NewAgentRegistered;
        SelectedViewModel = startVm;
        DataLoaded = true;
    }

    private void StartView_NewAgentRegistered(object? sender, IGameRegistrationResponse e)
    {
        if (sender is not StartViewModel startVm)
        {
            return;
        }

        startVm.NewAgentRegistered -= StartView_NewAgentRegistered;

        SelectedViewModel = new MainViewModel(e);
    }
}