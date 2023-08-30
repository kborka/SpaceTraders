using SpaceTraders.Core.Interfaces.Agents;

namespace SpaceTraders.Api.Services.Interfaces;

public interface IAgentService
{
    Task<IAgent?> GetAgent();
}