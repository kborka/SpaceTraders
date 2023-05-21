using SpaceTraders.Api.Models.Systems;

namespace SpaceTraders.Api.Models;

public class JumpGate
{
    /// <summary>
    ///     The maximum jump range of the gate.
    /// </summary>
    public decimal JumpRange { get; set; }

    /// <summary>
    ///     The symbol of the faction that owns the gate.
    /// </summary>
    public string? FactionSymbol { get; set; }

    /// <summary>
    ///     The systems within range of the gate that have a corresponding gate.
    /// </summary>
    public IEnumerable<ConnectedSystem> ConnectedSystems { get; set; } = null!;
}