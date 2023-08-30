using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Markets;

namespace SpaceTraders.Api.Models.Markets;

public class TradeGood : SymbolModelBase, ITradeGood
{
    /// <inheritdoc/>
    public string Name { get; set; } = null!;

    /// <inheritdoc/>
    public string Description { get; set; } = null!;
}
