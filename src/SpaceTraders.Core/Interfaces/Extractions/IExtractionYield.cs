using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Extractions;

/// <summary>
/// An interface representing the yield of an extraction.
/// </summary>
public interface IExtractionYield : ISymbolModel
{
    /// <summary>
    /// The number of units extracted that were placed into the ship's cargo hold.
    /// </summary>
    int Units { get; set; }
}
