using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Ioc;
using Prism.Mvvm;
using SpaceTraders.ComponentModel;
using SpaceTraders.Core.Interfaces.Game;
using SpaceTraders.Interfaces;
using SpaceTraders.Utilities;

namespace SpaceTraders.ViewModels;

public class MainWindowViewModel : BindableBase, IAsyncLoadingViewModel
{
    private bool _dataLoaded;
    private BindableBase? _selectedViewModel;

    public MainWindowViewModel()
    {
        InitializeCommand = new AsyncCommand(Initialize);
    }

    /// <inheritdoc/>
    public event EventHandler? InitializationCompleted;

    /// <inheritdoc/>
    public ICommand InitializeCommand { get; }

    public bool DataLoaded
    {
        get => _dataLoaded;
        private set => SetProperty(ref _dataLoaded, value);
    }

    public BindableBase? SelectedViewModel
    {
        get => _selectedViewModel;
        private set
        {
            UnsubscribeToSelectedVmEvents(_selectedViewModel);
            SetProperty(ref _selectedViewModel, value);
            SubscribeToSelectedVmEvents(_selectedViewModel);
        }
    }

    private Task Initialize()
    {
        var startVm = AppNexus.ApplicationContainer.Resolve<StartViewModel>();
        startVm.NewAgentRegistered += StartView_NewAgentRegistered;
        SelectedViewModel = startVm;
        return Task.CompletedTask;
    }

    private void SubscribeToSelectedVmEvents(BindableBase? selectedViewModel)
    {
        switch (selectedViewModel)
        {
            case IAsyncLoadingViewModel asyncLoadingViewModel:
                asyncLoadingViewModel.InitializationCompleted += SelectedViewModel_InitializationComplete;
                break;
        }
    }

    private void UnsubscribeToSelectedVmEvents(BindableBase? selectedViewModel)
    {
        switch (selectedViewModel)
        {
            case IAsyncLoadingViewModel asyncLoadingViewModel:
                asyncLoadingViewModel.InitializationCompleted -= SelectedViewModel_InitializationComplete;
                break;
        }
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

    private void SelectedViewModel_InitializationComplete(object? sender, EventArgs e)
    {
        if (sender is null) return;
        DataLoaded = ((IAsyncLoadingViewModel)sender).DataLoaded;
    }
}
