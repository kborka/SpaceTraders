using System.ComponentModel;
using Config.Net;
using Prism.Ioc;
using Prism.Mvvm;
using SpaceTraders.Api.Models.Interfaces.Game;
using SpaceTraders.Api.Services.Interfaces;
using SpaceTraders.ComponentModel;
using SpaceTraders.ComponentModel.Interfaces;
using SpaceTraders.Interfaces;
using SpaceTraders.Utilities;

namespace SpaceTraders.ViewModels;

public class MainWindowViewModel : BindableBase
{
    private bool _hasInitialData;
    private BindableBase? _selectedViewModel;
    private NotifyTaskCompletion<IGameStatus?> _gameStatus;
    private readonly IConnectionSettings _settings;
    private readonly IGameService _gameService;

    public MainWindowViewModel(IGameService gameService)
    {
        _gameService = gameService;
        _settings = new ConfigurationBuilder<IConnectionSettings>().UseAppConfig().Build();
        _gameStatus = new NotifyTaskCompletion<IGameStatus?>(gameService.GetStatus());
        _gameStatus.PropertyChanged += GameStatusOnPropertyChanged;
    }

    public bool HasInitialData
    {
        get => _hasInitialData;
        set => this.SetProperty(ref _hasInitialData, value);
    }

    public BindableBase? SelectedViewModel
    {
        get => _selectedViewModel;
        set => this.SetProperty(ref _selectedViewModel, value);
    }

    private void GameStatusOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {

        switch (e.PropertyName)
        {
            case nameof(INotifyTaskCompletion.IsCompletedSuccessfully):
            {
                HasInitialData = true;

                if (_settings.LastServerReset is null || _gameStatus.Result?.LastResetDate >= _settings.LastServerReset)
                {
                    _settings.LastServerReset = _gameStatus.Result?.LastResetDate;
                    _settings.AgentAuthToken = null;
                    SelectedViewModel = new StartViewModel(_gameStatus.Result);
                }
                else
                {
                    SelectedViewModel = AppNexus.ApplicationContainer.Resolve<MainViewModel>();
                }

                break;
            }
        }
    }

}