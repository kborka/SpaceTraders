using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Systems;

/// <summary>
/// An interface representing a system in space.
/// </summary>
public interface ISystem : ISymbolModel, ICoordinateModel
{
    /// <summary>
    /// Gets or sets the symbol of the sector.
    /// </summary>
    string SectorSymbol { get; set; }

    /// <summary>
    /// Gets or sets the type of the system.
    /// </summary>
    SystemType Type { get; set; }

    /// <summary>
    /// Gets or sets a collection of waypoints found in the system.
    /// </summary>
    IEnumerable<ISystemWaypoint> Waypoints { get; set; }

    /// <summary>
    /// Gets or sets a collection of factions that control this system.
    /// </summary>
    IEnumerable<ISystemFaction> Factions { get; set; }
}
