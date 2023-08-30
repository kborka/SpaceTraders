using SpaceTraders.Core.Interfaces.Waypoints;

namespace SpaceTraders.Api.Models.Waypoints;

/// <summary>
/// The chart of a system or waypoint, which makes the location visible to other agents.
/// </summary>
public class Chart : IChart
{
    /// <inheritdoc />
    public string? WayPointSymbol { get; set; }

    /// <inheritdoc />
    public string? SubmittedBy { get; set; }

    /// <inheritdoc />
    public DateTime? SubmittedOn { get; set; }
}
