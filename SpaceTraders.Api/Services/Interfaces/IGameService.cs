using SpaceTraders.Api.Models.Game;

namespace SpaceTraders.Api.Services.Interfaces;

/// <summary>
///     Interface for a service interacting with the game outside of a registered context.
/// </summary>
public interface IGameService
{
    /// <summary>
    ///     Gets the current status of the game.
    /// </summary>
    /// <returns>
    ///     A <see cref="GameStatus" /> object containing the current status, announcements, and leaderboards.
    /// </returns>
    Task<GameStatus?> GetStatus();

    /// <summary>
    ///     Registers an agent with the given <see cref="GameRegistrationRequest" /> information.
    /// </summary>
    /// <param name="registrationRequest">
    ///     The registration information to send to the server.
    /// </param>
    /// <returns>
    ///     A <see cref="GameRegistrationResponse" /> containing the agent's authorization token,
    ///     ship information, faction information, and contract information.
    /// </returns>
    Task<GameRegistrationResponse?> RegisterAgent(GameRegistrationRequest registrationRequest);
}