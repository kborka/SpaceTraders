using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

public class ShipModule : SymbolModelBase, IShipModule
{
    public ModuleType Type { get; set; }

    public uint? Capacity { get; set; }

    public uint? Range { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public IShipRequirements Requirements { get; set; } = null!;
}