namespace SpaceTraders.Api.Models.Interfaces.Extractions;

public interface IExtractionYield : ISymbolModel
{
    /// <summary>
    ///     The number of units extracted that were placed into the ship's cargo hold.
    /// </summary>
     int Units { get; set; }
}