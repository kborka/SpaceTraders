using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
/// The ship that was scanned. Details include information about the ship that could be detected by the scanner.
/// </summary>
public class ScannedShip : SymbolModelBase, IScannedShip
{
    /// <inheritdoc />
    public IShipRegistration Registration { get; set; } = null!;

    /// <inheritdoc />
    public IShipNav Nav { get; set; } = null!;

    /// <inheritdoc />
    public IShipFrame? Frame { get; set; }

    /// <inheritdoc />
    public IShipReactor? Reactor { get; set; }

    /// <inheritdoc />
    public IShipEngine Engine { get; set; } = null!;

    /// <inheritdoc />
    public IEnumerable<IShipMount>? Mounts { get; set; }
}
