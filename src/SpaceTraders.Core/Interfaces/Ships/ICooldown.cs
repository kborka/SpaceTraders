namespace SpaceTraders.Core.Interfaces.Ships;

/// <summary>
/// A cooldown is a period of time in which a ship cannot perform certain actions.
/// </summary>
public interface ICooldown
{
    /// <summary>
    /// Gets or sets the symbol of the ship that is on cooldown.
    /// </summary>
    string ShipSymbol { get; set; }

    /// <summary>
    /// Gets or sets the total duration of the cooldown in seconds.
    /// </summary>
    uint TotalSeconds { get; set; }

    /// <summary>
    /// Gets or sets the remaining duration of the cooldown in seconds.
    /// </summary>
    uint RemainingSeconds { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the cooldown expires in ISO 8601 format.
    /// </summary>
    DateTime? Expiration { get; set; }
}
