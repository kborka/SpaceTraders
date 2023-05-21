namespace SpaceTraders.Api.Models;

/// <summary>
///     A base class for models that contain a unique symbol.
/// </summary>
public abstract class SymbolModelBase
{
    /// <summary>
    ///     Gets or sets the symbol identifier.
    /// </summary>
    public string Symbol { get; set; } = null!;
}