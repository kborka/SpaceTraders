using SpaceTraders.Api.Models.Interfaces;
using SpaceTraders.Api.Models.Interfaces.Market;

namespace SpaceTraders.Api.Models.Market;

public class Market : SymbolModelBase, IMarket
{
    /// <summary>
    ///     The list of goods that are exported from this market.
    /// </summary>
    public IEnumerable<ITradeGood> Exports { get; set; } = null!;

    /// <summary>
    ///     The list of goods that are sought as imports in this market.
    /// </summary>
    public IEnumerable<ITradeGood> Imports { get; set; } = null!;

    /// <summary>
    ///     The list of goods that are bought and sold between agents at this market.
    /// </summary>
    public IEnumerable<ITradeGood> Exchange { get; set; } = null!;

    /// <summary>
    ///     The list of recent transactions at this market. Visible only when a ship is present at the market.
    /// </summary>
    public IEnumerable<IMarketTransaction>? Transactions { get; set; }

    /// <summary>
    ///     The list of goods that are traded at this market. Visible only when a ship is present at the market.
    /// </summary>
    public IEnumerable<IMarketTradeGood>? TradeGoods { get; set; }
}