using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Ships;

namespace SpaceTraders.Api.Models.Ships;

public class ShipCrew : IShipCrew
{
    /// <inheritdoc />
    public int Current { get; set; }

    /// <inheritdoc />
    public int Required { get; set; }

    /// <inheritdoc />
    public int Capacity { get; set; }

    /// <inheritdoc />
    public CrewRotationType Rotation { get; set; } = CrewRotationType.Strict;

    /// <inheritdoc />
    public ushort Morale { get; set; }

    /// <inheritdoc />
    public uint Wages { get; set; }
}
