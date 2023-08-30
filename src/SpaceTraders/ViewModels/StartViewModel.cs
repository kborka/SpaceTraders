using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using MaterialDesignThemes.Wpf;
using Prism.Ioc;
using Prism.Mvvm;
using SpaceTraders.Api;
using SpaceTraders.Api.Services.Interfaces;
using SpaceTraders.ComponentModel;
using SpaceTraders.ComponentModel.Interfaces;
using SpaceTraders.Core.Interfaces.Game;
using SpaceTraders.Interfaces;
using SpaceTraders.Settings;
using SpaceTraders.Utilities;
using SpaceTraders.ViewModels.Dialogs;
using SpaceTraders.ViewModels.Game;
using SpaceTraders.ViewModels.Settings;
using SpaceTraders.Views.Dialogs;

namespace SpaceTraders.ViewModels;

public sealed class StartViewModel : BindableBase, IAsyncLoadingViewModel
{
    private readonly IGameService _gameService;
    private bool _dataLoaded;
    private IGameStatus? _status;
    private GameStatsViewModel? _gameStats;
    private GameServerResetViewModel? _serverReset;
    private GameLeaderboardViewModel? _leaderboard;

    public StartViewModel(IGameService gameService)
    {
        _gameService = gameService;
        InitializeCommand = new AsyncCommand(Initialize);
        RegisteredAgents = new ObservableCollection<RegisteredAgentViewModel>();
        Announcements = new ObservableCollection<GameAnnouncementViewModel>();
        Links = new ObservableCollection<GameLinkViewModel>();
        OpenRegistrationDialogCommand = new AsyncCommand(OpenRegistrationDialog);
    }

    public event EventHandler<IGameRegistrationResponse>? NewAgentRegistered;

    /// <inheritdoc/>
    public event EventHandler? InitializationCompleted;

    /// <inheritdoc/>
    public ICommand InitializeCommand { get; }

    /// <inheritdoc/>
    public bool DataLoaded
    {
        get => _dataLoaded;
        private set => SetProperty(ref _dataLoaded, value);
    }

    public string? Status => _status?.Status;

    public string? Version => _status?.Version;

    public DateTime? LastResetDate => _status?.LastResetDate;

    public string? Description => _status?.Description;

    public GameStatsViewModel? Stats
    {
        get => _gameStats;
        private set => SetProperty(ref _gameStats, value);
    }

    public GameServerResetViewModel? NextServerReset
    {
        get => _serverReset;
        private set => SetProperty(ref _serverReset, value);
    }

    public GameLeaderboardViewModel? Leaderboard
    {
        get => _leaderboard;
        private set => SetProperty(ref _leaderboard, value);
    }

    public ObservableCollection<GameAnnouncementViewModel> Announcements { get; }

    public ObservableCollection<GameLinkViewModel> Links { get; }

    public ObservableCollection<RegisteredAgentViewModel> RegisteredAgents { get; }

    public IAsyncCommand OpenRegistrationDialogCommand { get; }

    private async Task Initialize()
    {
        _status= await _gameService.GetStatus();
        if (_status is null)
        {
            DataLoaded = false;
            InitializationCompleted?.Invoke(this, EventArgs.Empty);
            return;
        }

        RaisePropertyChanged(nameof(Description));
        Stats = new GameStatsViewModel(_status.Stats);
        NextServerReset = new GameServerResetViewModel(_status.NextServerReset);
        Leaderboard = new GameLeaderboardViewModel(_status.Leaderboards);

        foreach (var announcement in _status.Announcements)
        {
            Announcements.Add(new GameAnnouncementViewModel(announcement));
        }

        foreach (var link in _status.Links)
        {
            Links.Add(new GameLinkViewModel(link));
        }

        if (_status.LastResetDate > (UserSettings.LastServerReset ?? DateTime.UnixEpoch))
        {
            UserSettings.LastServerReset = _status.LastResetDate;
            UserSettings.RemoveAllAgents();
            RegisteredAgents.Clear();
        }
        else if (UserSettings.RegisteredAgents is not null)
        {
            foreach (var agent in UserSettings.RegisteredAgents)
            {
                RegisteredAgents.Add(new RegisteredAgentViewModel(agent));
            }
        }

        DataLoaded = true;
        InitializationCompleted?.Invoke(this, EventArgs.Empty);
    }

    private async Task OpenRegistrationDialog()
    {
        var dialogVm = AppNexus.ApplicationContainer.Resolve<RegistrationDialogViewModel>();
        var dialog = new RegistrationDialog
        {
            DataContext = dialogVm
        };

        await DialogHost.Show(dialog, "RootDialog", RegistrationDialog_Closing);
    }

    private void RegistrationDialog_Closing(object? sender, DialogClosingEventArgs e)
    {
        bool dialogResult = Convert.ToBoolean(e.Parameter);
        if (!dialogResult)
        {
            return;
        }

        if (e.Session.Content is not RegistrationDialog registrationDialog) return;
        var registrationInfo = ((RegistrationDialogViewModel)registrationDialog.DataContext).RegistrationInformation;

        if (registrationInfo is not null)
        {
            var newAgent = new RegisteredAgent(registrationInfo.Token, registrationInfo.Agent.Symbol,
                registrationInfo.Agent.Credits);

            UserSettings.AddNewAgent(newAgent);
        }

        ApiNexus.AuthToken = registrationInfo?.Token;

        if (registrationInfo is not null)
        {
            NewAgentRegistered?.Invoke(this, registrationInfo);
        }
    }
}
