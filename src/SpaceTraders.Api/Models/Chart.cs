﻿using SpaceTraders.Api.Models.Interfaces;

namespace SpaceTraders.Api.Models;

/// <summary>
///     The chart of a system or waypoint, which makes the location visible to other agents.
/// </summary>
public class Chart : IChart
{
    public string? WayPointSymbol { get; set; }

    public string? SubmittedBy { get; set; }

    public DateTime? SubmittedOn { get; set; }
}