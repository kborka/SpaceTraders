using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Factions;

namespace SpaceTraders.Api.Models.Factions;

public class Faction : SymbolModelBase, IFaction
{
    /// <inheritdoc/>
    public string Name { get; set; } = null!;

    /// <inheritdoc/>
    public string Description { get; set; } = null!;

    /// <inheritdoc/>
    public string Headquarters { get; set; } = null!;

    /// <inheritdoc/>
    public IEnumerable<IFactionTrait> Traits { get; set; } = null!;

    /// <inheritdoc/>
    public bool IsRecruiting { get; set; }
}
