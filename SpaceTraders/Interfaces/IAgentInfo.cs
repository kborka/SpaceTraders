namespace SpaceTraders.Interfaces;

public interface IAgentInfo
{
    string AuthToken { get; set; }

    string Symbol { get; set; }

    string Email { get; set; }

    uint Credits { get; set; }
}