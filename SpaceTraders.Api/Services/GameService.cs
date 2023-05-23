using System.Text.Json;
using SpaceTraders.Api.Models.Game;
using SpaceTraders.Api.Models.Interfaces.Game;
using SpaceTraders.Api.Services.Interfaces;

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
            var response = await GetValue<GameStatus>(string.Empty);
            return response;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }

        return null;
    }

    public async Task<IGameRegistrationResponse?> RegisterAgent(IGameRegistrationRequest registrationRequest)
    {
        try
        {
            var jsonRequestString = JsonSerializer.Serialize(registrationRequest);
            var response = await PostValue<GameRegistrationResponse?>("register", jsonRequestString);
            if (!response?.HasError ?? false) return response.Data;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }

        return null;
    }
}