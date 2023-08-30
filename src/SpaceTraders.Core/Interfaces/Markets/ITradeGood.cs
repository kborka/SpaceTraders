using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Markets;

/// <summary>
/// An interface representing a good that can be traded for other goods or currency.
/// </summary>
public interface ITradeGood : ISymbolModel, INameableModel, IDescriptableModel
{
}
