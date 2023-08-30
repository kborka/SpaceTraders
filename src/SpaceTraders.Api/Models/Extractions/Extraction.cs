using SpaceTraders.Core.Interfaces.Extractions;

namespace SpaceTraders.Api.Models.Extractions;

public class Extraction : IExtraction
{
    /// <inheritdoc/>
    public string ShipSymbol { get; set; } = null!;

    /// <inheritdoc/>
    public IExtractionYield Yield { get; set; } = null!;
}
