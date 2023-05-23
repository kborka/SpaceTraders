using SpaceTraders.Api.Models.Interfaces.Systems;

namespace SpaceTraders.Api.Models.Interfaces;

public interface IJumpGate
{
    /// <summary>
    ///     The maximum jump range of the gate.
    /// </summary>
    decimal JumpRange { get; set; }

    /// <summary>
    ///     The symbol of the faction that owns the gate.
    /// </summary>
    string? FactionSymbol { get; set; }

    /// <summary>
    ///     The systems within range of the gate that have a corresponding gate.
    /// </summary>
    IEnumerable<IConnectedSystem> ConnectedSystems { get; set; }
}