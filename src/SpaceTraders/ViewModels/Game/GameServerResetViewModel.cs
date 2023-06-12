using System;
using Prism.Mvvm;
using SpaceTraders.Api.Models.Interfaces.Game;

namespace SpaceTraders.ViewModels.Game;

public class GameServerResetViewModel : BindableBase
{
    public GameServerResetViewModel(IGameServerReset serverReset)
    {
        NextReset = serverReset.NextReset;
        Frequency = serverReset.Frequency;
    }

    public DateTime NextReset { get; }

    public string Frequency { get; }
}