using System;
using Prism.Mvvm;
using SpaceTraders.Core.Interfaces.Game;

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