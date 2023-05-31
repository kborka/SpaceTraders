namespace SpaceTraders.Api.Utilities;

public sealed class ClientSideRateLimitedHandler : DelegatingHandler
{
    private readonly SemaphoreSlim _throttler;

    public ClientSideRateLimitedHandler(SemaphoreSlim throttler) : base(new HttpClientHandler()) =>
        _throttler = throttler;

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        await _throttler.WaitAsync(cancellationToken);
        try
        {
            return await base.SendAsync(request, cancellationToken);
        }
        finally
        {
            _throttler.Release();
        }
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (disposing)
        {
            _throttler.Dispose();
        }
    }
}