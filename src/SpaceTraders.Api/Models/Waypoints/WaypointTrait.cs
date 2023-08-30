using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Interfaces.Waypoints;

namespace SpaceTraders.Api.Models.Waypoints;

public class WaypointTrait : SymbolModelBase, IWaypointTrait
{
    /// <inheritdoc />
    public string Name { get; set; } = null!;

    /// <inheritdoc />
    public string Description { get; set; } = null!;
}
