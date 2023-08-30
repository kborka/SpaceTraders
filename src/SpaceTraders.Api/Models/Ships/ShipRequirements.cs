using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
/// The requirements for installation on a ship.
/// </summary>
public class ShipRequirements : IShipRequirements
{
    /// <inheritdoc />
    public int Power { get; set; }

    /// <inheritdoc />
    public int Crew { get; set; }

    /// <inheritdoc />
    public int Slots { get; set; }
}
