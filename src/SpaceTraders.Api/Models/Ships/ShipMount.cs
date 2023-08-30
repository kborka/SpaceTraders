using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
/// A mount is installed on the exterior of a ship.
/// </summary>
public class ShipMount : SymbolModelBase, IShipMount
{
    /// <inheritdoc />
    public string Name { get; set; } = null!;

    /// <inheritdoc />
    public string Description { get; set; } = null!;

    /// <inheritdoc />
    public uint? Strength { get; set; }

    /// <inheritdoc />
    public IEnumerable<DepositTypes>? Deposits { get; set; }

    /// <inheritdoc />
    public IShipRequirements Requirements { get; set; } = null!;
}
