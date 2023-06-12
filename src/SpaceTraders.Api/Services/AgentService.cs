using SpaceTraders.Api.Models;
using SpaceTraders.Api.Models.Interfaces;
using SpaceTraders.Api.Services.Interfaces;

namespace SpaceTraders.Api.Services;

public class AgentService : ServiceBase, IAgentService
{
    public AgentService(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<IAgent?> GetAgent()
    {
        try
        {
            var response = await GetRequestDataValue<Agent>("my/agent");
            if (!response?.HasError ?? false) return response.Data;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }
}