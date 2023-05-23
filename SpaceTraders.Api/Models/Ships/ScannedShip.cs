using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     The ship that was scanned. Details include information about the ship that could be detected by the scanner.
/// </summary>
public class ScannedShip : SymbolModelBase, IScannedShip
{
    public IShipRegistration Registration { get; set; } = null!;

    public IShipNav Nav { get; set; } = null!;

    /// <summary>
    ///     The frame of the ship.
    /// </summary>
    public IShipFrame? Frame { get; set; }

    /// <summary>
    ///     The engine of the ship.
    /// </summary>
    public IShipEngine Engine { get; set; } = null!;

    /// <summary>
    ///     A mount on the ship
    /// </summary>
    public IEnumerable<IShipMount>? Mounts { get; set; }
}