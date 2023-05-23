using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     The engine determines how quickly a ship travels between waypoints.
/// </summary>
public class ShipEngine : SymbolModelBase, IShipEngine
{
    public EngineType Type { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public byte Condition { get; set; }

    public float Speed { get; set; }

    public IShipRequirements Requirements { get; set; } = null!;
}