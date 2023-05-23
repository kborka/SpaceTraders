using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     A mount is installed on the exterior of a ship.
/// </summary>
public class ShipMount : SymbolModelBase, IShipMount
{
    public MountType Type { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public uint? Strength { get; set; }

    public IEnumerable<DepositTypes>? Deposits { get; set; }

    public IShipRequirements Requirements { get; set; } = null!;
}