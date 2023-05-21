using System.Text.Json.Serialization;
using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Ships;

/// <summary>
///     The reactor of the ship. The reactor is responsible for powering the ship's systems and weapons.
/// </summary>
public class ShipReactor
{
    [JsonPropertyName("symbol")] public ReactorType Type { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public byte Condition { get; set; }

    public uint PowerOutput { get; set; }

    public ShipRequirements Requirements { get; set; } = null!;
}