using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Ships;

/// <summary>
///     The public registration information of the ship.
/// </summary>
public interface IShipRegistration
{
    /// <summary>
    ///     The agent's register name of the ship.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    ///     The symbol of the faction the ship is registered with.
    /// </summary>
    string FactionSymbol { get; set; }

    ShipRole Role { get; set; }
}