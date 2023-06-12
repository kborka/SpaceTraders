using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Ships;

/// <summary>
///     The engine determines how quickly a ship travels between waypoints.
/// </summary>
public interface IShipEngine : ISymbolModel
{
    EngineType Type { get; set; }

    string Name { get; set; }

    string Description { get; set; }

    byte Condition { get; set; }

    float Speed { get; set; }

    IShipRequirements Requirements { get; set; }
}