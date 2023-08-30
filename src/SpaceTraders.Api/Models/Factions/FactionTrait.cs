using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Factions;

namespace SpaceTraders.Api.Models.Factions;

public class FactionTrait : SymbolModelBase, IFactionTrait
{
    /// <inheritdoc/>
    public string Name { get; set; } = null!;

    /// <inheritdoc/>
    public string Description { get; set; } = null!;
}
