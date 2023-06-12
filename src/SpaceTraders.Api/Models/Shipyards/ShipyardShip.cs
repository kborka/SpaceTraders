using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Ships;
using SpaceTraders.Api.Models.Interfaces.Shipyards;

namespace SpaceTraders.Api.Models.Shipyards;

public class ShipyardShip : IShipyardShip
{
    public ShipType Type { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int PurchasePrice { get; set; }

    public IShipFrame Frame { get; set; } = null!;

    public IShipReactor Reactor { get; set; } = null!;

    public IShipEngine Engine { get; set; } = null!;

    public IEnumerable<IShipModule> Modules { get; set; } = null!;

    public IEnumerable<IShipMount> Mounts { get; set; } = null!;
}