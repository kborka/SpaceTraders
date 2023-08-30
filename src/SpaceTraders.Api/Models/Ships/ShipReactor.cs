using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
/// The reactor of the ship. The reactor is responsible for powering the ship's systems and weapons.
/// </summary>
public class ShipReactor : SymbolModelBase, IShipReactor
{
    /// <inheritdoc />
    public string Name { get; set; } = null!;

    /// <inheritdoc />
    public string Description { get; set; } = null!;

    /// <inheritdoc />
    public byte? Condition { get; set; }

    /// <inheritdoc />
    public uint PowerOutput { get; set; }

    /// <inheritdoc />
    public IShipRequirements Requirements { get; set; } = null!;
}
