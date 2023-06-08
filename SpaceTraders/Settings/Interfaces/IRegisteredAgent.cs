namespace SpaceTraders.Settings.Interfaces;

public interface IRegisteredAgent
{
    string Token { get; set; }

    string AgentSymbol { get; set; }

    long Credits { get; set; }
}