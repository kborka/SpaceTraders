namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     A ship
/// </summary>
public class Ship : SymbolModelBase
{
    public ShipRegistration Registration { get; set; } = null!;

    public ShipNav Nav { get; set; } = null!;

    public ShipCrew Crew { get; set; } = null!;

    public ShipFrame Frame { get; set; } = null!;

    public ShipRegistration Reactor { get; set; } = null!;

    public ShipEngine Engine { get; set; } = null!;

    public IEnumerable<ShipModule> Modules { get; set; } = null!;

    public IEnumerable<ShipMount> Mounts { get; set; } = null!;

    public ShipCargo Cargo { get; set; } = null!;

    public ShipFuel Fuel { get; set; } = null!;
}