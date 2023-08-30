using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
/// The public registration information of the ship.
/// </summary>
public class ShipRegistration : IShipRegistration
{
    /// <inheritdoc />
    public string Name { get; set; } = null!;

    /// <inheritdoc />
    public string FactionSymbol { get; set; } = null!;

    /// <inheritdoc />
    public ShipRole Role { get; set; }
}
