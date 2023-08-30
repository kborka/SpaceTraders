using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Markets;

namespace SpaceTraders.Api.Models.Markets;

public class MarketTradeGood : SymbolModelBase, IMarketTradeGood
{
    /// <inheritdoc/>
    public uint TradeVolume { get; set; }

    /// <inheritdoc/>
    public SupplyType Supply { get; set; }

    /// <inheritdoc/>
    public uint PurchasePrice { get; set; }

    /// <inheritdoc/>
    public uint SellPrice { get; set; }
}
