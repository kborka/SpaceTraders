using SpaceTraders.Core.Interfaces.Systems;

namespace SpaceTraders.Core.Interfaces.Waypoints;

/// <summary>
/// An interface representing a jump gate.
/// </summary>
public interface IJumpGate
{
    /// <summary>
    /// Gets or sets the maximum jump range of the gate.
    /// </summary>
    decimal JumpRange { get; set; }

    /// <summary>
    /// Gets or sets the symbol of the faction that owns the gate.
    /// </summary>
    string? FactionSymbol { get; set; }

    /// <summary>
    /// Gets or sets the systems within range of the gate that have a corresponding gate.
    /// </summary>
    IEnumerable<IConnectedSystem> ConnectedSystems { get; set; }
}
