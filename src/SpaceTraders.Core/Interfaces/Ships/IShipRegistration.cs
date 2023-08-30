using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// The public registration information of the ship.
/// </summary>
public interface IShipRegistration : INameableModel
{
    /// <summary>
    /// The symbol of the faction the ship is registered with.
    /// </summary>
    string FactionSymbol { get; set; }

    /// <summary>
    /// Gets or sets the registered role of the ship.
    /// </summary>
    ShipRole Role { get; set; }
}
