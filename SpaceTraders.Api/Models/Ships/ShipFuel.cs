namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     Details of the ship's fuel tanks including how much fuel was consumed during the last transit or action
/// </summary>
public class ShipFuel
{
    /// <summary>
    ///     The current amount of fuel in the ship's tanks.
    /// </summary>
    public uint Current { get; set; }

    /// <summary>
    ///     The maximum amount of fuel the ship's tanks can hold.
    /// </summary>
    public uint Capacity { get; set; }

    public ConsumedFuel? Consumed { get; set; }
}

public class ConsumedFuel
{
    /// <summary>
    ///     The amount of fuel consumed by the most recent transit or action.
    /// </summary>
    public uint Amount { get; set; }

    /// <summary>
    ///     The time at which the fuel was consumed.
    /// </summary>
    public DateTime Timestamp { get; set; }
}