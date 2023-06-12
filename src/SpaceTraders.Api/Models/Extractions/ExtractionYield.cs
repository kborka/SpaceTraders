using SpaceTraders.Api.Models.Interfaces.Extractions;

namespace SpaceTraders.Api.Models.Extractions;

public class ExtractionYield : SymbolModelBase, IExtractionYield
{
    /// <summary>
    ///     The number of units extracted that were placed into the ship's cargo hold.
    /// </summary>
    public int Units { get; set; }
}