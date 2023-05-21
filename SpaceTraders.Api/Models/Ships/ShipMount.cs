using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     A mount is installed on the exterior of a ship.
/// </summary>
public class ShipMount : SymbolModelBase
{
    public MountType Type { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public uint? Strength { get; set; }

    public IEnumerable<DepositTypes>? Deposits { get; set; }

    public ShipRequirements Requirements { get; set; } = null!;
}