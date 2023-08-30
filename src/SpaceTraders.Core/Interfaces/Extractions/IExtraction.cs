namespace SpaceTraders.Core.Interfaces.Extractions;

/// <summary>
/// An interface representing extraction details.
/// </summary>
public interface IExtraction
{
    /// <summary>
    /// Gets or sets the symbol of the ship that executed the extraction.
    /// </summary>
    string ShipSymbol { get; set; }

    /// <summary>
    /// Gets or sets the yield from the extraction operation.
    /// </summary>
    IExtractionYield Yield { get; set; }
}
