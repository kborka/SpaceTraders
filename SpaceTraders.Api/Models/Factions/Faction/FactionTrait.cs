using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Factions.Faction;

public class FactionTrait
{
    /// <summary>
    ///     The unique identifier of the trait.
    /// </summary>
    public FactionTraitType Symbol { get; set; }

    /// <summary>
    ///     The name of the trait.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    ///     A description of the trait.
    /// </summary>
    public string Description { get; set; } = null!;
}