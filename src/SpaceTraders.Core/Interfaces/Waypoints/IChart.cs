namespace SpaceTraders.Core.Interfaces.Waypoints;

/// <summary>
/// The chart of a system or waypoint, which makes the location visible to other agents.
/// </summary>
public interface IChart
{
    /// <summary>
    /// Gets or sets the symbol of the waypoint.
    /// </summary>
    string? WayPointSymbol { get; set; }

    /// <summary>
    /// Gets or sets the agent that submitted the chart for this waypoint.
    /// </summary>
    string? SubmittedBy { get; set; }

    /// <summary>
    /// Gets or sets the time the chart for this waypoint was submitted.
    /// </summary>
    DateTime? SubmittedOn { get; set; }
}
