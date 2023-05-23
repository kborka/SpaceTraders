using System.Text.Json.Serialization;

namespace SpaceTraders.Api.Models.Interfaces.Game;

public interface IGameServerReset
{
    string NextReset { get; set; }

    [JsonRequired]
    string Frequency { get; set; }
}