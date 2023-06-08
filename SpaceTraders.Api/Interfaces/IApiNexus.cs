using System.Text.Json;
using SpaceTraders.Api.Utilities;

namespace SpaceTraders.Api.Interfaces;

public interface IApiNexus
{
        ClientSideRateLimitedHandler RateLimitedHandler { get; }

        JsonSerializerOptions JsonOptions { get; }

        string? AuthToken { get; set; }

}