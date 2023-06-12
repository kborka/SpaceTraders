using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Market;

namespace SpaceTraders.Api.Models.Market;

public class MarketTradeGood : SymbolModelBase, IMarketTradeGood
{
    /// <summary>
    ///     The typical volume flowing through the market for this type of good.
    ///     The larger the trade volume, the more stable prices will be.
    /// </summary>
    public uint TradeVolume { get; set; }

    /// <summary>
    ///     A rough estimate of the total supply of this good in the marketplace.
    /// </summary>
    public SupplyType Supply { get; set; }

    /// <summary>
    ///     The price at which this good can be purchased from the market.
    /// </summary>
    public uint PurchasePrice { get; set; }

    /// <summary>
    ///     The price at which the good can be sold to the market.
    /// </summary>
    public uint SellPrice { get; set; }
}