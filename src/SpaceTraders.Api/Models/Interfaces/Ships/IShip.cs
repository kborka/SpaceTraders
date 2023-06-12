namespace SpaceTraders.Api.Models.Interfaces.Ships;

/// <summary>
///     A ship
/// </summary>
public interface IShip : ISymbolModel
{
    IShipRegistration Registration { get; set; }

    IShipNav Nav { get; set; }

    IShipCrew Crew { get; set; }

    IShipFrame Frame { get; set; }

    IShipRegistration Reactor { get; set; }

    IShipEngine Engine { get; set; }

    IEnumerable<IShipModule> Modules { get; set; }

    IEnumerable<IShipMount> Mounts { get; set; }

    IShipCargo Cargo { get; set; }

    IShipFuel Fuel { get; set; }
}