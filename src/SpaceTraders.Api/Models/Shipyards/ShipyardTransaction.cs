using SpaceTraders.Core.Interfaces.Shipyards;

namespace SpaceTraders.Api.Models.Shipyards;

public class ShipyardTransaction : IShipyardTransaction
{
    /// <inheritdoc />
    public string WaypointSymbol { get; set; } = null!;

    /// <inheritdoc />
    public string ShipSymbol { get; set; } = null!;

    /// <inheritdoc />
    public uint Price { get; set; }

    /// <inheritdoc />
    public string AgentSymbol { get; set; } = null!;

    /// <inheritdoc />
    public DateTime Timestamp { get; set; }
}
