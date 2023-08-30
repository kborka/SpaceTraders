using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Factions;

public interface IFaction : ISymbolModel
{
    /// <summary>
    /// The name of the faction.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// The description of the faction.
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// The waypoint in which the faction's HQ is located in.
    /// </summary>
    string Headquarters { get; set; }

    /// <summary>
    /// The list of traits that define this faction.
    /// </summary>
    IEnumerable<IFactionTrait> Traits { get; set; }

    /// <summary>
    /// Whether or not the faction is currently recruiting new agents.
    /// </summary>
    bool IsRecruiting { get; set; }
}
