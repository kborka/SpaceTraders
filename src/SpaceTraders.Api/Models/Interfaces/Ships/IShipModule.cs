using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Ships;

public interface IShipModule : ISymbolModel
{
    ModuleType Type { get; set; }

    uint? Capacity { get; set; }

    uint? Range { get; set; }

    string Name { get; set; }

    string? Description { get; set; }

    IShipRequirements Requirements { get; set; }
}