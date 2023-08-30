using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// An interface representing a mount that can be installed on a ship.
/// </summary>
/// <remarks>
/// A mount is installed on the exterior of a ship.
/// </remarks>
public interface IShipMount : ISymbolModel, INameableModel, IDescriptableModel
{
    /// <summary>
    /// Gets or sets how powerful this mount is.
    /// </summary>
    /// <remarks>
    /// Only mounts such as mining lasers will provide a non-null value.
    /// </remarks>
    uint? Strength { get; set; }

    /// <summary>
    /// Gets or sets the goods that can be produced by this mount.
    /// </summary>
    IEnumerable<DepositTypes>? Deposits { get; set; }

    /// <summary>
    /// Gets or sets the requirements for installing this mount on a ship.
    /// </summary>
    IShipRequirements Requirements { get; set; }
}
