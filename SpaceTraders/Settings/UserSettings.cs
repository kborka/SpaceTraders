using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using SpaceTraders.Settings.Interfaces;

namespace SpaceTraders.Settings;

public class UserSettings : IUserSettings
{
    private static readonly SemaphoreSlim SaveSemaphore = new(1, 1);
    private static readonly string SettingsPath = $"{AppDomain.CurrentDomain.BaseDirectory}\\Settings.json";
    private IList<IRegisteredAgent>? _registeredAgents;
    private DateTime? _lastServerReset;

    public IEnumerable<IRegisteredAgent>? RegisteredAgents => _registeredAgents;

    public DateTime? LastServerReset
    {
        get => _lastServerReset;
        set
        {
            _lastServerReset = value;
            Task.Run(SaveSettings);
        }
    }

    public void AddNewAgent(IRegisteredAgent agent)
    {
        _registeredAgents ??= new List<IRegisteredAgent>();

        _registeredAgents.Add(agent);
        Task.Run(SaveSettings);
    }

    public void RemoveAgent(string agentSymbol)
    {
        var foundAgent = _registeredAgents?.FirstOrDefault(a => a.AgentSymbol == agentSymbol);
        if (foundAgent != null) _registeredAgents?.Remove(foundAgent);
        Task.Run(SaveSettings);
    }

    public void RemoveAllAgents() => _registeredAgents?.Clear();

    public static UserSettings LoadUserSettings()
    {
        if (!File.Exists(SettingsPath))
        {
            return new UserSettings();
        }

        try
        {
            var fileText = File.ReadAllText(SettingsPath);
            var parsedSettings = JsonSerializer.Deserialize<UserSettings>(fileText);
            return parsedSettings ?? new UserSettings();
        }
        catch (Exception)
        {
            return new UserSettings();
        }
    }

    private async Task SaveSettings()
    {
        await SaveSemaphore.WaitAsync();
        await using var fileStream = File.Create(SettingsPath);
        await JsonSerializer.SerializeAsync(fileStream, this);
        await fileStream.DisposeAsync();
        SaveSemaphore.Release();
    }
}