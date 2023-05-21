using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Prism.Mvvm;
using SpaceTraders.Api.Models.Game;

namespace SpaceTraders.ViewModels.Game;

public class GameStatusViewModel : BindableBase
{
    private readonly GameStatus _status;

    public GameStatusViewModel(GameStatus status)
    {
        _status = status;
        Stats = new GameStatsViewModel(_status.Stats);
        NextServerReset = new GameServerResetViewModel(_status.NextServerReset);

        Announcements = new ObservableCollection<GameAnnouncementViewModel>();
        foreach (var announcement in _status.Announcements)
        {
            Announcements.Add(new GameAnnouncementViewModel(announcement));
        }

        Links = new ObservableCollection<GameLinkViewModel>();
        foreach (var link in _status.Links)
        {
            Links.Add(new GameLinkViewModel(link));
        }
    }

    public string Status => _status.Status;

    public string Version => _status.Version;

    public DateTime LastResetDate => _status.LastResetDate;

    public string Description => _status.Description;

    public GameStatsViewModel Stats { get; }

    public GameServerResetViewModel NextServerReset { get; }

    public ObservableCollection<GameAnnouncementViewModel> Announcements { get; }

    public ObservableCollection<GameLinkViewModel> Links { get; }
}