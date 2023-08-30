using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Markets;

/// <summary>
/// An interface representing information regarding a trade good sold at a market.
/// </summary>
public interface IMarketTradeGood : ISymbolModel
{
    /// <summary>
    /// The typical volume flowing through the market for this type of good.
    /// The larger the trade volume, the more stable prices will be.
    /// </summary>
    uint TradeVolume { get; set; }

    /// <summary>
    /// A rough estimate of the total supply of this good in the marketplace.
    /// </summary>
    SupplyType Supply { get; set; }

    /// <summary>
    /// The price at which this good can be purchased from the market.
    /// </summary>
    uint PurchasePrice { get; set; }

    /// <summary>
    /// The price at which the good can be sold to the market.
    /// </summary>
    uint SellPrice { get; set; }
}
