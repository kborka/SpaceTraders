using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
/// A cooldown is a period of time in which a ship cannot perform certain actions.
/// </summary>
public class Cooldown : ICooldown
{
    /// <inheritdoc />
    public string ShipSymbol { get; set; } = null!;

    /// <inheritdoc />
    public uint TotalSeconds { get; set; }

    /// <inheritdoc />
    public uint RemainingSeconds { get; set; }

    /// <inheritdoc />
    public DateTime? Expiration { get; set; }
}
