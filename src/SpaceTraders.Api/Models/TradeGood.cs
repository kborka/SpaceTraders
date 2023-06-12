using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces;

namespace SpaceTraders.Api.Models;

public class TradeGood : ITradeGood
{
    public TradeSymbol Symbol { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
}