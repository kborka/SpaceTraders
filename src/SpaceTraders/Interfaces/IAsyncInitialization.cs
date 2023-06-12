using System.Threading.Tasks;

namespace SpaceTraders.Interfaces;

public interface IAsyncInitialization
{
    public Task<bool> Initialization { get; }
}