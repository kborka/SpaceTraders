using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using SpaceTraders.Api.Models.Data;
using SpaceTraders.Api.Utilities;

namespace SpaceTraders.Api.Services;

public abstract class ServiceBase
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonOptions;

    protected ServiceBase(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(Constants.BaseUrl);
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ApiNexus.AuthToken);

        _jsonOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };
    }

    protected async Task<T?> GetValue<T>(string uri)
    {
        using var httpResponse = await _httpClient.GetAsync(uri, HttpCompletionOption.ResponseContentRead);
        httpResponse.EnsureSuccessStatusCode();

        if (httpResponse.Content.Headers.ContentType?.MediaType != MediaTypeNames.Application.Json) return default;

        var contentStream = await httpResponse.Content.ReadAsStreamAsync();

        try
        {
            return JsonSerializer.Deserialize<T>(contentStream, _jsonOptions);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    protected async Task<RequestData<T>?> GetRequestDataValue<T>(string uri) => await GetValue<RequestData<T>>(uri);

    protected async Task<RequestData<T>?> PostValue<T>(string uri, string jsonString)
    {
        var content = new StringContent(jsonString, Encoding.UTF8, MediaTypeNames.Application.Json);

        try
        {
            var httpResponse = await _httpClient.PostAsync(uri, content);
            httpResponse.EnsureSuccessStatusCode();

            if (httpResponse.Content.Headers.ContentType?.MediaType != MediaTypeNames.Application.Json)
                return default;

            var contentStream = await httpResponse.Content.ReadAsStreamAsync();
            return JsonSerializer.Deserialize<RequestData<T>>(contentStream);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}