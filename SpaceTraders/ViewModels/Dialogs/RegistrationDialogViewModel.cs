using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Game;
using SpaceTraders.Api.Models.Interfaces.Game;
using SpaceTraders.Api.Services.Interfaces;
using SpaceTraders.ComponentModel;
using SpaceTraders.ComponentModel.Interfaces;

namespace SpaceTraders.ViewModels.Dialogs;

public class RegistrationDialogViewModel : ValidatableBindableBase
{
    private readonly IGameService _gameService;
    private string? _agentSymbol;
    private StartingFactionType _faction;
    private string? _email;
    private IGameRegistrationResponse? _response;

    public RegistrationDialogViewModel(IGameService gameService)
    {
        _gameService = gameService;
        RegisterAgentCommand = new AsyncCommand(RegisterAgent, CanRegisterAgent);
        StartingFactions = Enum.GetValues<StartingFactionType>();
        _faction = StartingFactionType.Cosmic;
    }

    public IAsyncCommand RegisterAgentCommand { get; }

    public string? AgentSymbol
    {
        get => _agentSymbol;
        set
        {
            if (HasErrors)
            {
                ClearErrors(nameof(AgentSymbol));
            }

            SetProperty(ref _agentSymbol, value);
            RegisterAgentCommand.RaiseCanExecuteChanged();
        }
    }

    public IEnumerable<StartingFactionType> StartingFactions { get; }

    public StartingFactionType Faction
    {
        get => _faction;
        set => SetProperty(ref _faction, value);
    }

    public string? Email
    {
        get => _email;
        set
        {
            ValidateEmailAddress(value);
            SetProperty(ref _email, value);
            RegisterAgentCommand.RaiseCanExecuteChanged();
        }
    }

    public IGameRegistrationResponse? RegistrationInformation
    {
        get => _response;
        private set => SetProperty(ref _response, value);
    }

    private async Task RegisterAgent()
    {
        var registration = new GameRegistrationRequest()
        {
            Symbol = AgentSymbol,
            Faction = Faction,
            Email = Email
        };

        var response = await _gameService.RegisterAgent(registration);

        if (response is null)
        {
            return;
        }

        if (!response.HasError)
        {
            RegistrationInformation = response.Data;
        }
        else if (response.Error?.Data.Symbol is not null)
        {
            AddError(nameof(AgentSymbol), response.Error.Data.Symbol.FirstOrDefault() ?? string.Empty);
        }
    }

    private bool CanRegisterAgent()
    {
        if (_agentSymbol is null) return false;
        if (_email is null) return false;
        return !HasErrors;
    }

    private bool ValidateEmailAddress(string? address)
    {
        if (address is null)
        {
            return false;
        }

        ClearErrors(nameof(Email));

        try
        {
            var m = new MailAddress(address);
        }
        catch (FormatException)
        {
            AddError(nameof(Email), "Invalid email address format.");
            return false;
        }

        return true;
    }
}