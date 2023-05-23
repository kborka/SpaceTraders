using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Factions;

public interface IFactionTrait
{
    /// <summary>
    ///     The unique identifier of the trait.
    /// </summary>
    FactionTraitType Symbol { get; set; }

    /// <summary>
    ///     The name of the trait.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    ///     A description of the trait.
    /// </summary>
    string Description { get; set; }
}