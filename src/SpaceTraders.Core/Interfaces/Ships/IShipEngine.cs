using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// The engine determines how quickly a ship travels between waypoints.
/// </summary>
public interface IShipEngine : ISymbolModel, INameableModel, IDescriptableModel, IWearableModel
{
    /// <summary>
    /// The speed stat of this ship.
    /// </summary>
    uint Speed { get; set; }

    /// <summary>
    /// The requirements for installing this piece on a ship.
    /// </summary>
    IShipRequirements Requirements { get; set; }
}
