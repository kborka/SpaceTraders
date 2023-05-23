using System.Text.Json.Serialization;

namespace SpaceTraders.Api.Models.Interfaces.Game;

public interface IGameAnnouncement
{
    string Title { get; set; }

    string Body { get; set; }
}