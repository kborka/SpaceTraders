using SpaceTraders.Core.Enums;

namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// An interface representing a ship's crew.
/// </summary>
public interface IShipCrew
{
    /// <summary>
    /// The current number of crew members on the ship.
    /// </summary>
    int Current { get; set; }

    /// <summary>
    /// The minimum number of crew members to maintain the ship.
    /// </summary>
    int Required { get; set; }

    /// <summary>
    /// The maximum number of crew members teh ship can support.
    /// </summary>
    int Capacity { get; set; }

    /// <summary>
    /// The rotation of the crew shifts.<br/>
    /// A stricter shift improves the ship's performance.<br/>
    /// A more relaxed shift improves the crew's morale.<br/>
    /// </summary>
    CrewRotationType Rotation { get; set; }

    /// <summary>
    /// A rough measure of the crew's morale.<br/>
    /// A higher morale means the crew is happier and more productive.<br/>
    /// A lower morale means the ship is more prone to accidents.<br/>
    /// </summary>
    ushort Morale { get; set; }

    /// <summary>
    /// The mount of credits per crew member paid per hour. Wages are paid when a ship docks at a civilized waypoint.
    /// </summary>
    uint Wages { get; set; }
}
