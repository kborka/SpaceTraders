using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using SpaceTraders.Api.Models.Data;
using SpaceTraders.Api.Utilities;
using SpaceTraders.Core.Interfaces.Data;

namespace SpaceTraders.Api.Services;

public abstract class ServiceBase
{
    private readonly HttpClient _httpClient;

    protected ServiceBase(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(Constants.BaseUrl);
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ApiNexus.AuthToken);
    }

    protected async Task<T?> GetValue<T>(string uri)
    {
        using var httpResponse = await _httpClient.GetAsync(uri, HttpCompletionOption.ResponseContentRead);

        if (httpResponse.Content.Headers.ContentType?.MediaType != MediaTypeNames.Application.Json) return default;

        var contentStream = await httpResponse.Content.ReadAsStreamAsync();

        try
        {
            return JsonSerializer.Deserialize<T>(contentStream, ApiNexus.JsonOptions);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    protected async Task<IRequestData<T>?> GetRequestDataValue<T>(string uri) => await GetValue<RequestData<T>>(uri);

    protected async Task<IRequestData<T>?> PostValue<T>(string uri, string jsonString)
    {
        var content = new StringContent(jsonString, Encoding.UTF8, MediaTypeNames.Application.Json);

        try
        {
            var httpResponse = await _httpClient.PostAsync(uri, content);


            if (httpResponse.Content.Headers.ContentType?.MediaType != MediaTypeNames.Application.Json)
                return default;

            var contentStream = await httpResponse.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<RequestData<T>>(contentStream, ApiNexus.JsonOptions);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}