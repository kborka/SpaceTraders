namespace SpaceTraders.Api.Models.Extractions.Extraction;

public class ExtractionYield : SymbolModelBase
{
    /// <summary>
    ///     The number of units extracted that were placed into the ship's cargo hold.
    /// </summary>
    public int Units { get; set; }
}