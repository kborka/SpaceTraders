namespace SpaceTraders.Api.Models.Market;

public class Market : SymbolModelBase
{
    /// <summary>
    ///     The list of goods that are exported from this market.
    /// </summary>
    public IEnumerable<TradeGood> Exports { get; set; } = null!;

    /// <summary>
    ///     The list of goods that are sought as imports in this market.
    /// </summary>
    public IEnumerable<TradeGood> Imports { get; set; } = null!;

    /// <summary>
    ///     The list of goods that are bought and sold between agents at this market.
    /// </summary>
    public IEnumerable<TradeGood> Exchange { get; set; } = null!;

    /// <summary>
    ///     The list of recent transactions at this market. Visible only when a ship is present at the market.
    /// </summary>
    public IEnumerable<MarketTransaction>? Transactions { get; set; }

    /// <summary>
    ///     The list of goods that are traded at this market. Visible only when a ship is present at the market.
    /// </summary>
    public IEnumerable<MarketTradeGood>? TradeGoods { get; set; }
}