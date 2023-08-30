using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// Interface representing a ship.
/// </summary>
/// <remarks>
/// Ship symbols are globally unique and follow the format: [AGENT_SYMBOL]-[HEX_ID]
/// </remarks>
public interface IShip : ISymbolModel
{
    /// <summary>
    /// The public registration information of the ship.
    /// </summary>
    IShipRegistration Registration { get; set; }

    /// <summary>
    /// The navigation information of the ship.
    /// </summary>
    IShipNav Nav { get; set; }

    /// <summary>
    /// The crew information of this ship.
    /// </summary>
    IShipCrew Crew { get; set; }

    /// <summary>
    /// The frame of the ship.
    /// </summary>
    IShipFrame Frame { get; set; }

    /// <summary>
    /// The reactor of the ship.
    /// </summary>
    IShipRegistration Reactor { get; set; }

    /// <summary>
    /// The engine of the ship.
    /// </summary>
    IShipEngine Engine { get; set; }

    /// <summary>
    /// The modules installed on the ship.
    /// </summary>
    IEnumerable<IShipModule> Modules { get; set; }

    /// <summary>
    /// The mounts installed on the ship.
    /// </summary>
    IEnumerable<IShipMount> Mounts { get; set; }

    /// <summary>
    /// The cargo the ship is carrying.
    /// </summary>
    IShipCargo Cargo { get; set; }

    /// <summary>
    /// The ship's fuel tanks.
    /// </summary>
    IShipFuel Fuel { get; set; }
}
