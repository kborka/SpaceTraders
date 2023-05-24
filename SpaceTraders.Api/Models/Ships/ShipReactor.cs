using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     The reactor of the ship. The reactor is responsible for powering the ship's systems and weapons.
/// </summary>
public class ShipReactor : IShipReactor
{
    public ReactorType Type { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public byte Condition { get; set; }

    public uint PowerOutput { get; set; }

    public IShipRequirements Requirements { get; set; } = null!;
}