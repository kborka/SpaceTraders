namespace SpaceTraders.Api.Models.Interfaces;

/// <summary>
///     The chart of a system or waypoint, which makes the location visible to other agents.
/// </summary>
public interface IChart
{
    string? WayPointSymbol { get; set; }

    string? SubmittedBy { get; set; }

    DateTime? SubmittedOn { get; set; }
}