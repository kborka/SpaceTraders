using System.Text.Json.Serialization;

namespace SpaceTraders.Core.Interfaces.Game;

public interface IGameServerReset
{
    DateTime NextReset { get; set; }

    [JsonRequired] string Frequency { get; set; }
}
