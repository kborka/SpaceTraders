using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Markets;

namespace SpaceTraders.Api.Models.Markets;

public class Market : SymbolModelBase, IMarket
{
    /// <inheritdoc/>
    public IEnumerable<ITradeGood> Exports { get; set; } = null!;

    /// <inheritdoc/>
    public IEnumerable<ITradeGood> Imports { get; set; } = null!;

    /// <inheritdoc/>
    public IEnumerable<ITradeGood> Exchange { get; set; } = null!;

    /// <inheritdoc/>
    public IEnumerable<IMarketTransaction>? Transactions { get; set; }

    /// <inheritdoc/>
    public IEnumerable<IMarketTradeGood>? TradeGoods { get; set; }
}
