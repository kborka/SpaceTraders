using System.Text.Json.Serialization;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Api.Models.Core;

/// <summary>
/// A base class for models that contain a unique symbol.
/// </summary>
public abstract class SymbolModelBase : ISymbolModel
{
    /// <inheritdoc/>
    [JsonRequired]
    public string Symbol { get; set; } = null!;
}
