using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Ships;

/// <summary>
///     A mount is installed on the exterior of a ship.
/// </summary>
public interface IShipMount : ISymbolModel
{
    MountType Type { get; set; }

    string Name { get; set; }

    string? Description { get; set; }

    uint? Strength { get; set; }

    IEnumerable<DepositTypes>? Deposits { get; set; }

    IShipRequirements Requirements { get; set; }
}