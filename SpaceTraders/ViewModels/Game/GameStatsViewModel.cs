using Prism.Mvvm;
using SpaceTraders.Api.Models.Interfaces.Game;

namespace SpaceTraders.ViewModels.Game;

public class GameStatsViewModel : BindableBase
{
    public GameStatsViewModel(IGameStats stats)
    {
        AgentCount = stats.AgentCount;
        ShipCount = stats.ShipCount;
        SystemCount = stats.SystemCount;
        WaypointCount = stats.WaypointCount;
    }

    public uint AgentCount { get; }

    public uint ShipCount { get; }

    public uint SystemCount { get; }

    public uint WaypointCount { get; }
}