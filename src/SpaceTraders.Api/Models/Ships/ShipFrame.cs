using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
/// The frame of the ship. The frame determines the number of modules and mounting points of the ship,
/// as well as base fuel capacity. As the condition of the frame takes more wear, the ship will become
/// more sluggish and less maneuverable.
/// </summary>
public class ShipFrame : SymbolModelBase, IShipFrame
{
    /// <inheritdoc />
    public string Name { get; set; } = null!;

    /// <inheritdoc />
    public string Description { get; set; } = null!;

    /// <inheritdoc />
    public uint ModuleSlots { get; set; }

    /// <inheritdoc />
    public uint MountingPoints { get; set; }

    /// <inheritdoc />
    public byte? Condition { get; set; }

    /// <inheritdoc />
    public uint FuelCapacity { get; set; }

    /// <inheritdoc />
    public IShipRequirements Requirements { get; set; } = null!;
}
