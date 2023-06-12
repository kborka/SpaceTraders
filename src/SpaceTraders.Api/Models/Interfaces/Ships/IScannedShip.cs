namespace SpaceTraders.Api.Models.Interfaces.Ships;

/// <summary>
///     The ship that was scanned. Details include information about the ship that could be detected by the scanner.
/// </summary>
public interface IScannedShip : ISymbolModel
{
    IShipRegistration Registration { get; set; }

    IShipNav Nav { get; set; }

    /// <summary>
    ///     The frame of the ship.
    /// </summary>
    IShipFrame? Frame { get; set; }

    /// <summary>
    ///     The engine of the ship.
    /// </summary>
    IShipEngine Engine { get; set; }

    /// <summary>
    ///     A mount on the ship
    /// </summary>
    IEnumerable<IShipMount>? Mounts { get; set; }
}