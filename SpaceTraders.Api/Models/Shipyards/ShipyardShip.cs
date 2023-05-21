using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Ships;

namespace SpaceTraders.Api.Models.Shipyards;

public class ShipyardShip
{
    public ShipType Type { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int PurchasePrice { get; set; }

    public ShipFrame Frame { get; set; } = null!;

    public ShipReactor Reactor { get; set; } = null!;

    public ShipEngine Engine { get; set; } = null!;

    public IEnumerable<ShipModule> Modules { get; set; } = null!;

    public IEnumerable<ShipMount> Mounts { get; set; } = null!;
}