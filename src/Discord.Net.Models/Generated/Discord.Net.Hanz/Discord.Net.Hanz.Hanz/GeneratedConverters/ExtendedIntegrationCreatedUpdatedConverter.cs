using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedIntegrationCreatedUpdatedConverter : JsonConverter<IntegrationCreatedUpdated>
{
    private static JsonTypeInfo<Discord.Models.Json.IntegrationCreatedUpdated>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.IntegrationCreatedUpdated> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateIntegrationCreatedUpdatedTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateIntegrationCreatedUpdatedTypeInfoNoConverter(options);
    }

    public override Discord.Models.Json.IntegrationCreatedUpdated? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        var element = jsonDocument.RootElement;
        var result = element.Deserialize(GetTypeInfoWithoutConverter(options));
        if (result is null)
            return null;
        result.Integration = element.Deserialize<Discord.Models.Json.Integration>(options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.IntegrationCreatedUpdated value, JsonSerializerOptions options)
    {
        var node = JsonSerializer.SerializeToNode(value, GetTypeInfoWithoutConverter(options)) as System.Text.Json.Nodes.JsonObject;
        if (node is null)
            return;
        var IntegrationProp = JsonSerializer.SerializeToNode(value.Integration, options) as System.Text.Json.Nodes.JsonObject;
        if (IntegrationProp is not null)
        {
            foreach (var prop in IntegrationProp)
                node.Add(prop);
        }

        node.WriteTo(writer, options);
    }
}