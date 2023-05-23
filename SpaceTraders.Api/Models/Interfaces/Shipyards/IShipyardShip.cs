using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Interfaces.Shipyards;

public interface IShipyardShip
{
    ShipType Type { get; set; }

    string Name { get; set; }

    string Description { get; set; }

    int PurchasePrice { get; set; }

    IShipFrame Frame { get; set; }

    IShipReactor Reactor { get; set; }

    IShipEngine Engine { get; set; }

    IEnumerable<IShipModule> Modules { get; set; }

    IEnumerable<IShipMount> Mounts { get; set; }
}