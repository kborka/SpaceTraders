using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

public class ShipModule : SymbolModelBase, IShipModule
{
    /// <inheritdoc />
    public uint? Capacity { get; set; }

    /// <inheritdoc />
    public uint? Range { get; set; }

    /// <inheritdoc />
    public string Name { get; set; } = null!;

    /// <inheritdoc />
    public string Description { get; set; } = null!;

    /// <inheritdoc />
    public IShipRequirements Requirements { get; set; } = null!;
}
