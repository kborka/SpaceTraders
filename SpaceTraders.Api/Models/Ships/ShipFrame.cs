using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     The frame of the ship. The frame determines the number of modules and mounting points of the ship,
///     as well as base fuel capacity. As the condition of the frame takes more wear, the ship will become
///     more sluggish and less maneuverable.
/// </summary>
public class ShipFrame
{
    public FrameType Symbol { get; set; }

    public string Name { get; set; } = null!;

    public string Descrption { get; set; } = null!;

    public uint ModuleSlots { get; set; }

    public uint MountPoints { get; set; }

    public uint FuelCapacity { get; set; }

    public ShipRequirements Requirements { get; set; } = null!;
}