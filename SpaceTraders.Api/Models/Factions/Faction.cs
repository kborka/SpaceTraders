using SpaceTraders.Api.Models.Interfaces.Factions;

namespace SpaceTraders.Api.Models.Factions;

public class Faction : SymbolModelBase, IFaction
{
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Headquarters { get; set; } = null!;

    public IEnumerable<IFactionTrait> Traits { get; set; } = null!;

    /// <summary>
    ///     Whether or not the faction is currently recruiting new agents.
    /// </summary>
    public bool IsRecruiting { get; set; }
}