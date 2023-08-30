using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// An interface representing the frame of a ship.
/// </summary>
/// <remarks>
/// The frame of the ship. The frame determines the number of modules and mounting points of the ship,
/// as well as base fuel capacity. As the condition of the frame takes more wear, the ship will become
/// more sluggish and less maneuverable.
/// </remarks>
public interface IShipFrame : ISymbolModel, INameableModel, IDescriptableModel, IWearableModel
{
    /// <summary>
    /// Gets or sets the number of slots that can be dedicated to installing modules on the ship.
    /// </summary>
    uint ModuleSlots { get; set; }

    /// <summary>
    /// Gets or sets the number of slots that can be dedicated to installing mounts on the ship.
    /// </summary>
    uint MountingPoints { get; set; }

    /// <summary>
    /// Gets or sets the maximum amount of fuel that can be stored in the ship.
    /// </summary>
    /// <remarks>
    /// When refueling, ships will be refueled to this amount.
    /// </remarks>
    uint FuelCapacity { get; set; }

    /// <summary>
    /// Gets or sets the requirements for this to be installed on a ship.
    /// </summary>
    IShipRequirements Requirements { get; set; }
}
