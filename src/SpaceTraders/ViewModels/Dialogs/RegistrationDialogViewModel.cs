using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Input;
using SpaceTraders.Api.Models.Game;
using SpaceTraders.Api.Services.Interfaces;
using SpaceTraders.ComponentModel;
using SpaceTraders.ComponentModel.Interfaces;
using SpaceTraders.Core.Interfaces.Game;
using SpaceTraders.Interfaces;
using SpaceTraders.ViewModels.Factions;

namespace SpaceTraders.ViewModels.Dialogs;

public class RegistrationDialogViewModel : ValidatableBindableBase, IAsyncLoadingViewModel
{
    private readonly IGameService _gameService;
    private readonly IFactionService _factionService;
    private bool _dataLoaded;
    private string? _agentSymbol;
    private FactionViewModel? _selectedFaction;
    private string? _email;
    private IGameRegistrationResponse? _response;

    public RegistrationDialogViewModel(IGameService gameService, IFactionService factionService)
    {
        _gameService = gameService;
        _factionService = factionService;
        RegisterAgentCommand = new AsyncCommand(RegisterAgent, CanRegisterAgent);
        InitializeCommand = new AsyncCommand(Initialize);
        StartingFactions = new ObservableCollection<FactionViewModel>();
    }

    public event EventHandler? InitializationCompleted;

    /// <inheritdoc/>
    public ICommand InitializeCommand { get; }

    public IAsyncCommand RegisterAgentCommand { get; }

    /// <inheritdoc/>
    public bool DataLoaded
    {
        get => _dataLoaded;
        private set => SetProperty(ref _dataLoaded, value);
    }

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

    public ObservableCollection<FactionViewModel> StartingFactions { get; }

    public FactionViewModel? SelectedFaction
    {
        get => _selectedFaction;
        set => SetProperty(ref _selectedFaction, value);
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
        var registration = new GameRegistrationRequest
        {
            Symbol = AgentSymbol!,
            Faction = SelectedFaction!.Symbol,
            Email = Email!
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
        if (!_selectedFaction?.IsRecruiting ?? true) return false;
        return !HasErrors;
    }

    private void ValidateEmailAddress(string? address)
    {
        if (address is null)
        {
            return;
        }

        ClearErrors(nameof(Email));

        try
        {
            var _ = new MailAddress(address);
        }
        catch (FormatException)
        {
            AddError(nameof(Email), "Invalid email address format.");
        }
    }

    private async Task Initialize()
    {
        var factions = await _factionService.GetFactions();
        foreach (var faction in factions)
        {
            StartingFactions.Add(new FactionViewModel(faction));
        }

        SelectedFaction = StartingFactions.First();

        DataLoaded = true;
    }
}
