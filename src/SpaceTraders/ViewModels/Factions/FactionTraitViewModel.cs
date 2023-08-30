using SpaceTraders.Core.Interfaces.Factions;

namespace SpaceTraders.ViewModels.Factions;

public class FactionTraitViewModel
{
    public FactionTraitViewModel(IFactionTrait factionTrait)
    {
        Name = factionTrait.Name;
        Description = factionTrait.Description;
    }

    public string Name { get; }

    public string Description { get; }
}
