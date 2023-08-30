using SpaceTraders.Core.Interfaces.Systems;
using SpaceTraders.Core.Interfaces.Waypoints;

namespace SpaceTraders.Api.Models.Waypoints;

public class JumpGate : IJumpGate
{
    /// <inheritdoc />
    public decimal JumpRange { get; set; }

    /// <inheritdoc />
    public string? FactionSymbol { get; set; }

    /// <inheritdoc />
    public IEnumerable<IConnectedSystem> ConnectedSystems { get; set; } = null!;
}
