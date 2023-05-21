using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models;

public class TradeGood
{
    public TradeSymbol Symbol { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
}