using SpaceTraders.Api.Models.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     The requirements for installation on a ship.
/// </summary>
public class ShipRequirements : IShipRequirements
{
    /// <summary>
    ///     The amount of power required from the reactor.
    /// </summary>
    public int Power { get; set; }

    /// <summary>
    ///     The number of crew required for operation.
    /// </summary>
    public int Crew { get; set; }

    /// <summary>
    ///     The number of module slots required for installation.
    /// </summary>
    public int Slots { get; set; }
}