namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// Details of the ship's fuel tanks including how much fuel was consumed during the last transit or action
/// </summary>
public interface IShipFuel
{
    /// <summary>
    /// The current amount of fuel in the ship's tanks.
    /// </summary>
    uint Current { get; set; }

    /// <summary>
    /// The maximum amount of fuel the ship's tanks can hold.
    /// </summary>
    uint Capacity { get; set; }

    /// <summary>
    /// Gets or sets the amount of fuel consumed by an action.
    /// </summary>
    /// <remarks>
    /// This will only have a value when an action consumes fuel in the process.
    /// </remarks>
    IConsumedFuel? Consumed { get; set; }
}

public interface IConsumedFuel
{
    /// <summary>
    /// The amount of fuel consumed by the most recent transit or action.
    /// </summary>
    uint Amount { get; set; }

    /// <summary>
    /// The time at which the fuel was consumed.
    /// </summary>
    DateTime Timestamp { get; set; }
}
