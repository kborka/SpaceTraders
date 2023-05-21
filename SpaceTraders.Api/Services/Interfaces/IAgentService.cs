using SpaceTraders.Api.Models;

namespace SpaceTraders.Api.Services.Interfaces;

public interface IAgentService
{
    Task<Agent?> GetAgent();
}