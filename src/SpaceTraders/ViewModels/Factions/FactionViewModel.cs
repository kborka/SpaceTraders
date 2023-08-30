using System.Collections.Generic;
using System.Linq;
using Prism.Mvvm;
using SpaceTraders.Core.Interfaces.Factions;

namespace SpaceTraders.ViewModels.Factions;

public class FactionViewModel : BindableBase
{
    public FactionViewModel(IFaction faction)
    {
        Symbol = faction.Symbol;
        Name = faction.Name;
        Description = faction.Description;
        Traits = faction.Traits.Select(trait => new FactionTraitViewModel(trait));
        IsRecruiting = faction.IsRecruiting;
    }

    public string Symbol { get; }

    public string Name { get; }

    public string Description { get; }

    public IEnumerable<FactionTraitViewModel> Traits { get; }

    public bool IsRecruiting { get; }
}
