namespace SpaceTraders.Core.Interfaces.Core;

/// <summary>
/// A base class for models that contain a unique symbol.
/// </summary>
public interface ISymbolModel
{
    /// <summary>
    /// Gets or sets the symbol identifier.
    /// </summary>
    string Symbol { get; set; }
}
