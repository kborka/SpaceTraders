namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     The ship that was scanned. Details include information about the ship that could be detected by the scanner.
/// </summary>
public class ScannedShip : SymbolModelBase
{
    public ShipRegistration Registration { get; set; } = null!;

    public ShipNav Nav { get; set; } = null!;

    /// <summary>
    ///     The frame of the ship.
    /// </summary>
    public ShipFrame? Frame { get; set; }

    /// <summary>
    ///     The engine of the ship.
    /// </summary>
    public ShipEngine Engine { get; set; } = null!;

    /// <summary>
    ///     A mount on the ship
    /// </summary>
    public IEnumerable<ShipMount>? Mounts { get; set; }
}