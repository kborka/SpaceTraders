using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// The reactor of the ship. The reactor is responsible for powering the ship's systems and weapons.
/// </summary>
public interface IShipReactor : ISymbolModel, INameableModel, IDescriptableModel, IWearableModel
{
    /// <summary>
    /// Gets or sets the power provided by this reactor.
    /// </summary>
    /// <remarks>
    /// The more power a reactor provides, the lower the cooldown when using a module or mount that taxes
    /// the ship's power.
    /// </remarks>
    uint PowerOutput { get; set; }

    /// <summary>
    /// Gets or sets the requirements for installing this on a ship.
    /// </summary>
    IShipRequirements Requirements { get; set; }
}
