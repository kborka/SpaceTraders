namespace SpaceTraders.Api.Models.Interfaces.Extractions;

public interface IExtraction
{
    string ShipSymbol { get; set; }

    IExtractionYield Yield { get; set; }
}