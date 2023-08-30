using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpaceTraders.Core.Utilities.Json;

/// <summary>
/// A factory for generating JSON converters between implementations and interfaces.
/// Code taken from https://gist.github.com/tonysneed/5e7988516b081d454cde95b5d729e1af
/// </summary>
/// <typeparam name="TImplementation">
/// The implementation type of the interface that will be converted.
/// </typeparam>
/// <typeparam name="TInterface">
/// The interface to be converted.
/// </typeparam>
public class InterfaceJsonConverterFactory<TImplementation, TInterface> : JsonConverterFactory
where TImplementation : class, TInterface
{
    public Type ImplementationType { get; }

    public Type InterfaceType { get; }

    public InterfaceJsonConverterFactory()
    {
        ImplementationType = typeof(TImplementation);
        InterfaceType = typeof(TInterface);
    }

    public override bool CanConvert(Type typeToConvert) => typeToConvert == InterfaceType;

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converterType = typeof(InterfaceJsonConverter<,>).MakeGenericType(ImplementationType, InterfaceType);
        return Activator.CreateInstance(converterType) as JsonConverter;
    }
}
