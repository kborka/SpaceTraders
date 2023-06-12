namespace SpaceTraders.Api.Models.Interfaces.Factions;

public interface IFaction : ISymbolModel
{
    string Name { get; set; }

    string Description { get; set; }

    string Headquarters { get; set; }

    IEnumerable<IFactionTrait> Traits { get; set; }

    /// <summary>
    ///     Whether or not the faction is currently recruiting new agents.
    /// </summary>
    bool IsRecruiting { get; set; }
}