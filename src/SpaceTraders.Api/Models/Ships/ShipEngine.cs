using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
/// The engine determines how quickly a ship travels between waypoints.
/// </summary>
public class ShipEngine : SymbolModelBase, IShipEngine
{
    /// <inheritdoc />
    public string Name { get; set; } = null!;

    /// <inheritdoc />
    public string Description { get; set; } = null!;

    /// <inheritdoc />
    public byte? Condition { get; set; }

    /// <inheritdoc />
    public uint Speed { get; set; }

    /// <inheritdoc />
    public IShipRequirements Requirements { get; set; } = null!;
}
