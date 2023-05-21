namespace SpaceTraders.Api.Models.Extractions.Extraction;

public class Extraction
{
    public string ShipSymbol { get; set; } = null!;

    public ExtractionYield Yield { get; set; } = null!;
}