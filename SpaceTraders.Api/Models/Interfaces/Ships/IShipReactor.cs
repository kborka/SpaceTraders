using System.Text.Json.Serialization;
using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Ships;

/// <summary>
///     The reactor of the ship. The reactor is responsible for powering the ship's systems and weapons.
/// </summary>
public interface IShipReactor
{
    [JsonPropertyName("symbol")]
    ReactorType Type { get; set; }

    string Name { get; set; }

    string Description { get; set; }

    byte Condition { get; set; }

    uint PowerOutput { get; set; }

    IShipRequirements Requirements { get; set; }
}