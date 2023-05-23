using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Ships;

/// <summary>
///     The frame of the ship. The frame determines the number of modules and mounting points of the ship,
///     as well as base fuel capacity. As the condition of the frame takes more wear, the ship will become
///     more sluggish and less maneuverable.
/// </summary>
public interface IShipFrame
{
    FrameType Symbol { get; set; }

    string Name { get; set; }

    string Description { get; set; }

    uint ModuleSlots { get; set; }

    uint MountPoints { get; set; }

    uint FuelCapacity { get; set; }

    IShipRequirements Requirements { get; set; }
}