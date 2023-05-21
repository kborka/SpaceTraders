namespace SpaceTraders.Api.Models;

/// <summary>
///     A cooldown is a period of time in which a ship cannot perform certain actions.
/// </summary>
public class Cooldown
{
    /// <summary>
    ///     The symbol of the ship that is on cooldown.
    /// </summary>
    public string ShipSymbol { get; set; } = null!;

    /// <summary>
    ///     The total duration of the cooldown in seconds.
    /// </summary>
    public uint TotalSeconds { get; set; }

    /// <summary>
    ///     The remaining duration of the cooldown in seconds.
    /// </summary>
    public uint RemainingSeconds { get; set; }

    /// <summary>
    ///     The date and time when the cooldown expires in ISO 8601 format.
    /// </summary>
    public DateTime? Expiration { get; set; }
}