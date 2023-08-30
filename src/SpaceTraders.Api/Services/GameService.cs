using System.Text.Json;
using SpaceTraders.Api.Services.Interfaces;
using SpaceTraders.Core.Interfaces.Data;
using SpaceTraders.Core.Interfaces.Game;

namespace SpaceTraders.Api.Services;

public class GameService : ServiceBase, IGameService
{
    public GameService(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<IGameStatus?> GetStatus()
    {
        try
        {
            var response = await GetValue<IGameStatus>(string.Empty);
            return response;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }

        return null;
    }

    public async Task<IRequestData<IGameRegistrationResponse?>?> RegisterAgent(IGameRegistrationRequest registrationRequest)
    {
        try
        {
            var jsonRequestString = JsonSerializer.Serialize(registrationRequest, ApiNexus.JsonOptions);
            return await PostValue<IGameRegistrationResponse?>("register", jsonRequestString);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }

        return null;
    }
}