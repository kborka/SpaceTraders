using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     The public registration information of the ship.
/// </summary>
public class ShipRegistration : IShipRegistration
{
    /// <summary>
    ///     The agent's register name of the ship.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    ///     The symbol of the faction the ship is registered with.
    /// </summary>
    public string FactionSymbol { get; set; } = null!;

    public ShipRole Role { get; set; }
}