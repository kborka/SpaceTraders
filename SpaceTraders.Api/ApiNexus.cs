using SpaceTraders.Api.Utilities;

namespace SpaceTraders.Api;

public static class ApiNexus
{
    private static _ApiNexus? _instance;

    private class _ApiNexus
    {
        public _ApiNexus()
        {
            RateLimitedHandler = new ClientSideRateLimitedHandler(new SemaphoreSlim(2));
        }

        public ClientSideRateLimitedHandler RateLimitedHandler { get; }
        public string? AuthToken { get; set; }
    }

    public static ClientSideRateLimitedHandler RateLimitedHandler => Instance.RateLimitedHandler;

    public static string? AuthToken
    {
        get => Instance.AuthToken;
        set => Instance.AuthToken = value;
    }

    private static _ApiNexus Instance
    {
        get
        {
            if (_instance is null)
            {
                _instance = new _ApiNexus();
            }

            return _instance;
        }
    }
}