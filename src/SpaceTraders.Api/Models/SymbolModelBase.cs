﻿using System.Text.Json.Serialization;
using SpaceTraders.Api.Models.Interfaces;

namespace SpaceTraders.Api.Models;

/// <summary>
///     A base class for models that contain a unique symbol.
/// </summary>
public abstract class SymbolModelBase : ISymbolModel
{
    /// <summary>
    ///     Gets or sets the symbol identifier.
    /// </summary>
    [JsonRequired]
    public string Symbol { get; set; } = null!;
}