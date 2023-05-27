using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Mvvm;
using SpaceTraders.Api.Models.Interfaces.Game;
using SpaceTraders.Api.Services.Interfaces;
using SpaceTraders.Interfaces;
using SpaceTraders.ViewModels.Game;

namespace SpaceTraders.ViewModels;

public sealed class StartViewModel : BindableBase, IAsyncInitialization
{
    private IGameStatus? _status;
    private readonly IGameService _gameService;
    private GameStatsViewModel? _gameStats;
    private GameServerResetViewModel? _serverReset;
    private GameLeaderboardViewModel? _leaderboard;

    public StartViewModel(IGameService gameService)
    {
        _gameService = gameService;
        Initialization = InitializeAsync();
        Announcements = new ObservableCollection<GameAnnouncementViewModel>();
        Links = new ObservableCollection<GameLinkViewModel>();
    }

    public Task<bool> Initialization { get; }

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
        set => SetProperty(ref _leaderboard, value);
    }

    public ObservableCollection<GameAnnouncementViewModel> Announcements { get; }

    public ObservableCollection<GameLinkViewModel> Links { get; }

    private async Task<bool> InitializeAsync()
    {
        _status= await _gameService.GetStatus();
        if (_status is null) return false;

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

        return true;
    }

}