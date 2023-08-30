using SpaceTraders.Core.Interfaces.Factions;

namespace SpaceTraders.Api.Services.Interfaces;

public interface IFactionService
{
    Task<IEnumerable<IFaction>?> GetFactions();
}