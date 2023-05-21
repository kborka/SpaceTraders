using SpaceTraders.Api.Models.Factions.Faction;
using SpaceTraders.Api.Services.Interfaces;

namespace SpaceTraders.Api.Services;

public class FactionService : ServiceBase, IFactionService
{
    public FactionService(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<IEnumerable<Faction>?> GetFactions()
    {
        try
        {
            var response = await GetRequestDataValue<IEnumerable<Faction>?>("factions");
            if (!response?.HasError ?? false) return response.Data;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }
}