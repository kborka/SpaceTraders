using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Ships;

public class ShipModule : SymbolModelBase
{
    public ModuleType Type { get; set; }

    public uint? Capacity { get; set; }

    public uint? Range { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public ShipRequirements Requirements { get; set; } = null!;
}