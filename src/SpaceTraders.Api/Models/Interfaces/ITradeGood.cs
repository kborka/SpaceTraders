using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces;

public interface ITradeGood
{
    TradeSymbol Symbol { get; set; }

    string Name { get; set; }

    string Description { get; set; }
}