using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using SpaceTraders.Core.Utilities.Json;
using SpaceTraders.Settings.Interfaces;

namespace SpaceTraders.Settings;

public static class UserSettings
{
    private static readonly string SettingsPath = $"{AppDomain.CurrentDomain.BaseDirectory}\\Settings.json";
    // ReSharper disable once InconsistentNaming
    private static readonly Lazy<IUserSettings> _instance = new(LoadUserSettings);

    public static IEnumerable<IRegisteredAgent>? RegisteredAgents => Instance.RegisteredAgents;

    public static DateTime? LastServerReset
    {
        get => Instance.LastServerReset;
        set => Instance.LastServerReset = value;
    }

    private static IUserSettings Instance => _instance.Value;

    public static void AddNewAgent(IRegisteredAgent agent) => Instance.AddNewAgent(agent);

    public static void RemoveAgent(string agentSymbol) => Instance.RemoveAgent(agentSymbol);

    public static void RemoveAllAgents() => Instance.RemoveAllAgents();

    private static IUserSettings LoadUserSettings()
    {
        if (!File.Exists(SettingsPath))
        {
            return new UserSettingsNested();
        }

        try
        {
            var fileText = File.ReadAllText(SettingsPath);
            var jsonOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters =
                {
                    new InterfaceJsonConverterFactory<UserSettingsNested, IUserSettings>(),
                    new InterfaceJsonConverterFactory<RegisteredAgent, IRegisteredAgent>()
                }
            };
            var parsedSettings = JsonSerializer.Deserialize<UserSettingsNested>(fileText, jsonOptions);
            return parsedSettings ?? new UserSettingsNested();
        }
        catch (Exception)
        {
            return new UserSettingsNested();
        }
    }

    private class UserSettingsNested : IUserSettings
    {
        private static readonly SemaphoreSlim SaveSemaphore = new(1, 1);
        private IList<IRegisteredAgent>? _registeredAgents;
        private DateTime? _lastServerReset;

        // ReSharper disable once MemberHidesStaticFromOuterClass
        public IEnumerable<IRegisteredAgent>? RegisteredAgents
        {
            get => _registeredAgents;
            set => _registeredAgents = value as IList<IRegisteredAgent>;
        }

        // ReSharper disable once MemberHidesStaticFromOuterClass
        public DateTime? LastServerReset
        {
            get => _lastServerReset;
            set
            {
                _lastServerReset = value;
                Task.Run(SaveSettings);
            }
        }

        IEnumerable<IRegisteredAgent>? IUserSettings.RegisteredAgents => RegisteredAgents;

        DateTime? IUserSettings.LastServerReset
        {
            get => LastServerReset;
            set => LastServerReset = value;
        }

        void IUserSettings.AddNewAgent(IRegisteredAgent agent)
        {
            _registeredAgents ??= new List<IRegisteredAgent>();

            _registeredAgents.Add(agent);
            Task.Run(SaveSettings);
        }

        void IUserSettings.RemoveAgent(string agentSymbol)
        {
            var foundAgent = _registeredAgents?.FirstOrDefault(a => a.AgentSymbol == agentSymbol);
            if (foundAgent != null) _registeredAgents?.Remove(foundAgent);
            Task.Run(SaveSettings);
        }

        void IUserSettings.RemoveAllAgents() => _registeredAgents?.Clear();

        private async Task SaveSettings()
        {
            await SaveSemaphore.WaitAsync();
            await using var fileStream = File.Create(SettingsPath);
            await JsonSerializer.SerializeAsync(fileStream, this);
            await fileStream.DisposeAsync();
            SaveSemaphore.Release();
        }
    }
}