using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
/// Details of the ship's fuel tanks including how much fuel was consumed during the last transit or action
/// </summary>
public class ShipFuel : IShipFuel
{
    /// <inheritdoc />
    public uint Current { get; set; }

    /// <inheritdoc />
    public uint Capacity { get; set; }

    /// <inheritdoc />
    public IConsumedFuel? Consumed { get; set; }
}

public class ConsumedFuel : IConsumedFuel
{
    /// <inheritdoc />
    public uint Amount { get; set; }

    /// <inheritdoc />
    public DateTime Timestamp { get; set; }
}
