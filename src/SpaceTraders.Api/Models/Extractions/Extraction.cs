using SpaceTraders.Api.Models.Interfaces.Extractions;

namespace SpaceTraders.Api.Models.Extractions;

public class Extraction : IExtraction
{
    public string ShipSymbol { get; set; } = null!;

    public IExtractionYield Yield { get; set; } = null!;
}