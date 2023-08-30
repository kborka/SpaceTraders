using System.Text.Json;
using System.Text.Json.Serialization;
using SpaceTraders.Api.Interfaces;
using SpaceTraders.Api.Models.Agents;
using SpaceTraders.Api.Models.Contracts;
using SpaceTraders.Api.Models.Data;
using SpaceTraders.Api.Models.Extractions;
using SpaceTraders.Api.Models.Factions;
using SpaceTraders.Api.Models.Game;
using SpaceTraders.Api.Models.Markets;
using SpaceTraders.Api.Models.Ships;
using SpaceTraders.Api.Models.Surveys;
using SpaceTraders.Api.Models.Systems;
using SpaceTraders.Api.Models.Waypoints;
using SpaceTraders.Api.Utilities;
using SpaceTraders.Core.Interfaces.Agents;
using SpaceTraders.Core.Interfaces.Contracts;
using SpaceTraders.Core.Interfaces.Data;
using SpaceTraders.Core.Interfaces.Extractions;
using SpaceTraders.Core.Interfaces.Factions;
using SpaceTraders.Core.Interfaces.Game;
using SpaceTraders.Core.Interfaces.Markets;
using SpaceTraders.Core.Interfaces.Ships;
using SpaceTraders.Core.Interfaces.Surveying;
using SpaceTraders.Core.Interfaces.Systems;
using SpaceTraders.Core.Interfaces.Waypoints;
using SpaceTraders.Core.Utilities.Json;

namespace SpaceTraders.Api;

public static class ApiNexus
{
    // ReSharper disable once InconsistentNaming
    private static readonly Lazy<IApiNexus> _instance = new(() => new ApiNexusNested());

    private class ApiNexusNested : IApiNexus
    {
        private readonly ClientSideRateLimitedHandler _rateLimitedHandler = new(new SemaphoreSlim(2,2));
        private readonly JsonSerializerOptions _jsonOptions = new()
                                                              {
                                                                  PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                                                                  WriteIndented = true,
                                                                  Converters =
                                                                  {
                                                                      new JsonStringEnumMemberConverter(),
                                                                      new InterfaceJsonConverterFactory<Agent, IAgent>(),
                                                                      new InterfaceJsonConverterFactory<Chart, IChart>(),
                                                                      new InterfaceJsonConverterFactory<ConnectedSystem, IConnectedSystem>(),
                                                                      new InterfaceJsonConverterFactory<ConsumedFuel, IConsumedFuel>(),
                                                                      new InterfaceJsonConverterFactory<Contract, IContract>(),
                                                                      new InterfaceJsonConverterFactory<ContractDeliverGood, IContractDeliverGood>(),
                                                                      new InterfaceJsonConverterFactory<ContractPayment, IContractPayment>(),
                                                                      new InterfaceJsonConverterFactory<ContractTerms, IContractTerms>(),
                                                                      new InterfaceJsonConverterFactory<Cooldown, ICooldown>(),
                                                                      new InterfaceJsonConverterFactory<Error, IError>(),
                                                                      new InterfaceJsonConverterFactory<ErrorData, IErrorData>(),
                                                                      new InterfaceJsonConverterFactory<Extraction, IExtraction>(),
                                                                      new InterfaceJsonConverterFactory<ExtractionYield, IExtractionYield>(),
                                                                      new InterfaceJsonConverterFactory<Faction, IFaction>(),
                                                                      new InterfaceJsonConverterFactory<FactionTrait, IFactionTrait>(),
                                                                      new InterfaceJsonConverterFactory<GameRegistrationResponse, IGameRegistrationResponse>(),
                                                                      new InterfaceJsonConverterFactory<GameStatus, IGameStatus>(),
                                                                      new InterfaceJsonConverterFactory<JumpGate, IJumpGate>(),
                                                                      new InterfaceJsonConverterFactory<Market, IMarket>(),
                                                                      new InterfaceJsonConverterFactory<MarketTradeGood, IMarketTradeGood>(),
                                                                      new InterfaceJsonConverterFactory<MarketTransaction, IMarketTransaction>(),
                                                                      new InterfaceJsonConverterFactory<Meta, IMeta>(),
                                                                      new InterfaceJsonConverterFactory<ScannedShip, IScannedShip>(),
                                                                      new InterfaceJsonConverterFactory<ScannedSystem, IScannedSystem>(),
                                                                      new InterfaceJsonConverterFactory<ScannedWaypoint, IScannedWaypoint>(),
                                                                      new InterfaceJsonConverterFactory<Ship, IShip>(),
                                                                      new InterfaceJsonConverterFactory<ShipCargo, IShipCargo>(),
                                                                      new InterfaceJsonConverterFactory<ShipCargoItem, IShipCargoItem>(),
                                                                      new InterfaceJsonConverterFactory<ShipCrew, IShipCrew>(),
                                                                      new InterfaceJsonConverterFactory<ShipEngine, IShipEngine>(),
                                                                      new InterfaceJsonConverterFactory<ShipFrame, IShipFrame>(),
                                                                      new InterfaceJsonConverterFactory<ShipFuel, IShipFuel>(),
                                                                      new InterfaceJsonConverterFactory<ShipModule, IShipModule>(),
                                                                      new InterfaceJsonConverterFactory<ShipMount, IShipMount>(),
                                                                      new InterfaceJsonConverterFactory<ShipNav, IShipNav>(),
                                                                      new InterfaceJsonConverterFactory<ShipNavRoute, IShipNavRoute>(),
                                                                      new InterfaceJsonConverterFactory<ShipNavRouteWaypoint, IShipNavRouteWaypoint>(),
                                                                      new InterfaceJsonConverterFactory<ShipReactor, IShipReactor>(),
                                                                      new InterfaceJsonConverterFactory<ShipRegistration, IShipRegistration>(),
                                                                      new InterfaceJsonConverterFactory<ShipRequirements, IShipRequirements>(),
                                                                      new InterfaceJsonConverterFactory<Survey, ISurvey>(),
                                                                      new InterfaceJsonConverterFactory<SurveyDeposit, ISurveyDeposit>(),
                                                                      new InterfaceJsonConverterFactory<Models.Systems.System, ISystem>(),
                                                                      new InterfaceJsonConverterFactory<SystemFaction, ISystemFaction>(),
                                                                      new InterfaceJsonConverterFactory<SystemWaypoint, ISystemWaypoint>(),
                                                                      new InterfaceJsonConverterFactory<Waypoint, IWaypoint>(),
                                                                      new InterfaceJsonConverterFactory<WaypointFaction, IWaypointFaction>(),
                                                                      new InterfaceJsonConverterFactory<WaypointOrbital, IWaypointOrbital>(),
                                                                      new InterfaceJsonConverterFactory<WaypointTrait, IWaypointTrait>(),
                                                                      new InterfaceJsonConverterFactory<TradeGood, ITradeGood>()
                                                                  }
                                                              };

        ClientSideRateLimitedHandler IApiNexus.RateLimitedHandler => _rateLimitedHandler;

        JsonSerializerOptions IApiNexus.JsonOptions => _jsonOptions;

        string? IApiNexus.AuthToken { get; set; }
    }

    public static ClientSideRateLimitedHandler RateLimitedHandler => Instance.RateLimitedHandler;

    public static string? AuthToken
    {
        get => Instance.AuthToken;
        set => Instance.AuthToken = value;
    }

    public static JsonSerializerOptions JsonOptions => Instance.JsonOptions;

    private static IApiNexus Instance => _instance.Value;
}
