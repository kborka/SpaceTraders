using SpaceTraders.Api.Models.Factions.Faction;

namespace SpaceTraders.Api.Services.Interfaces;

public interface IFactionService
{
    Task<IEnumerable<Faction>?> GetFactions();
}