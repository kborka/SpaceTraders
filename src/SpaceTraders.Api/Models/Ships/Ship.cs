using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
/// A ship
/// </summary>
public class Ship : SymbolModelBase, IShip
{
    /// <inheritdoc />
    public IShipRegistration Registration { get; set; } = null!;

    /// <inheritdoc />
    public IShipNav Nav { get; set; } = null!;

    /// <inheritdoc />
    public IShipCrew Crew { get; set; } = null!;

    /// <inheritdoc />
    public IShipFrame Frame { get; set; } = null!;

    /// <inheritdoc />
    public IShipRegistration Reactor { get; set; } = null!;

    /// <inheritdoc />
    public IShipEngine Engine { get; set; } = null!;

    /// <inheritdoc />
    public IEnumerable<IShipModule> Modules { get; set; } = null!;

    /// <inheritdoc />
    public IEnumerable<IShipMount> Mounts { get; set; } = null!;

    /// <inheritdoc />
    public IShipCargo Cargo { get; set; } = null!;

    /// <inheritdoc />
    public IShipFuel Fuel { get; set; } = null!;
}
