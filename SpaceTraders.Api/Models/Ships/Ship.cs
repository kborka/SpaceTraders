using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     A ship
/// </summary>
public class Ship : SymbolModelBase, IShip
{
    public IShipRegistration Registration { get; set; } = null!;

    public IShipNav Nav { get; set; } = null!;

    public IShipCrew Crew { get; set; } = null!;

    public IShipFrame Frame { get; set; } = null!;

    public IShipRegistration Reactor { get; set; } = null!;

    public IShipEngine Engine { get; set; } = null!;

    public IEnumerable<IShipModule> Modules { get; set; } = null!;

    public IEnumerable<IShipMount> Mounts { get; set; } = null!;

    public IShipCargo Cargo { get; set; } = null!;

    public IShipFuel Fuel { get; set; } = null!;
}