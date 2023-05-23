namespace SpaceTraders.Api.Models.Interfaces.Ships;

/// <summary>
///     The requirements for installation on a ship.
/// </summary>
public interface IShipRequirements
{
    /// <summary>
    ///     The amount of power required from the reactor.
    /// </summary>
    int Power { get; set; }

    /// <summary>
    ///     The number of crew required for operation.
    /// </summary>
    int Crew { get; set; }

    /// <summary>
    ///     The number of module slots required for installation.
    /// </summary>
    int Slots { get; set; }
}