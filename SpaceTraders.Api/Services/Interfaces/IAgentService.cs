using SpaceTraders.Api.Models.Interfaces;

namespace SpaceTraders.Api.Services.Interfaces;

public interface IAgentService
{
    Task<IAgent?> GetAgent();
}