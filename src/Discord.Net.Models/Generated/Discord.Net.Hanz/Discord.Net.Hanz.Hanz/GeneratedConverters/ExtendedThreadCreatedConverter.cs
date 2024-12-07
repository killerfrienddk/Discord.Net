using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedThreadCreatedConverter : JsonConverter<ThreadCreated>
{
    private static JsonTypeInfo<Discord.Models.Json.ThreadCreated>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.ThreadCreated> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateThreadCreatedTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateThreadCreatedTypeInfoNoConverter(options);
    }

    public override Discord.Models.Json.ThreadCreated? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        var element = jsonDocument.RootElement;
        var result = element.Deserialize(GetTypeInfoWithoutConverter(options));
        if (result is null)
            return null;
        result.Thread = element.Deserialize<Discord.Models.Json.ThreadChannelBase>(options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.ThreadCreated value, JsonSerializerOptions options)
    {
        var node = JsonSerializer.SerializeToNode(value, GetTypeInfoWithoutConverter(options)) as System.Text.Json.Nodes.JsonObject;
        if (node is null)
            return;
        var ThreadProp = JsonSerializer.SerializeToNode(value.Thread, options) as System.Text.Json.Nodes.JsonObject;
        if (ThreadProp is not null)
        {
            foreach (var prop in ThreadProp)
                node.Add(prop);
        }

        node.WriteTo(writer, options);
    }
}