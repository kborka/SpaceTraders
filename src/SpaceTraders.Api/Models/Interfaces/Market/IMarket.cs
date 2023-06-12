namespace SpaceTraders.Api.Models.Interfaces.Market;

public interface IMarket : ISymbolModel
{
    /// <summary>
    ///     The list of goods that are exported from this market.
    /// </summary>
    IEnumerable<ITradeGood> Exports { get; set; }

    /// <summary>
    ///     The list of goods that are sought as imports in this market.
    /// </summary>
    IEnumerable<ITradeGood> Imports { get; set; }

    /// <summary>
    ///     The list of goods that are bought and sold between agents at this market.
    /// </summary>
    IEnumerable<ITradeGood> Exchange { get; set; }

    /// <summary>
    ///     The list of recent transactions at this market. Visible only when a ship is present at the market.
    /// </summary>
    IEnumerable<IMarketTransaction>? Transactions { get; set; }

    /// <summary>
    ///     The list of goods that are traded at this market. Visible only when a ship is present at the market.
    /// </summary>
    IEnumerable<IMarketTradeGood>? TradeGoods { get; set; }
}