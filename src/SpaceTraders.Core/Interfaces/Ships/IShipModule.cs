using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// An interface that represents a module that can be installed on a ship.
/// </summary>
/// <remarks>
/// Modules provide a set of capabilities, such as storage space or crew quarters. Module installations are permanent.
/// </remarks>
public interface IShipModule : ISymbolModel, INameableModel, IDescriptableModel
{
    /// <summary>
    /// Gets or sets the amount of bonus capacity this module provides.
    /// </summary>
    /// <remarks>
    /// Only modules such as cargo hold or crew quarters will provide a non-null value.
    /// </remarks>
    uint? Capacity { get; set; }

    /// <summary>
    /// Gets or sets the range a module can reach.
    /// </summary>
    /// <remarks>
    /// Only modules such as a sensor array will provide a non-null value.
    /// </remarks>
    uint? Range { get; set; }

    /// <summary>
    /// Gets or sets the requirements for installing this module on a ship.
    /// </summary>
    IShipRequirements Requirements { get; set; }
}
