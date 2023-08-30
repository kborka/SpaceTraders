using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// The ship that was scanned. Details include information about the ship that could be detected by the scanner.
/// </summary>
public interface IScannedShip : ISymbolModel
{
    /// <summary>
    /// Gets or sets the public registration information of the ship.
    /// </summary>
    IShipRegistration Registration { get; set; }

    /// <summary>
    /// Gets or sets the navigation information of the ship.
    /// </summary>
    IShipNav Nav { get; set; }

    /// <summary>
    /// Gets or sets the frame of the ship.
    /// </summary>
    IShipFrame? Frame { get; set; }

    /// <summary>
    /// Gets or sets the reactor of the ship.
    /// </summary>
    IShipReactor? Reactor { get; set; }

    /// <summary>
    /// Gets or sets the engine of the ship.
    /// </summary>
    IShipEngine Engine { get; set; }

    /// <summary>
    /// A mount on the ship
    /// </summary>
    IEnumerable<IShipMount>? Mounts { get; set; }
}
