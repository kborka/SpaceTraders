namespace SpaceTraders.Api.Models.Factions.Faction;

public class Faction : SymbolModelBase
{
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Headquarters { get; set; } = null!;

    public IEnumerable<FactionTrait> Traits { get; set; } = null!;

    /// <summary>
    ///     Whether or not the faction is currently recruiting new agents.
    /// </summary>
    public bool IsRecruiting { get; set; }
}