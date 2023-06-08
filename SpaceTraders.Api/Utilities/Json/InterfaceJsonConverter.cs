using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpaceTraders.Api.Utilities.Json;

public class InterfaceJsonConverter<TImplementation, TInterface> : JsonConverter<TInterface>
where TImplementation : class, TInterface
{
    public override TInterface? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => JsonSerializer.Deserialize<TImplementation>(ref reader, options);

    public override void Write(Utf8JsonWriter writer, TInterface value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}