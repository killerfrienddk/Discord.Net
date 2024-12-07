using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedMessageCreatedUpdatedConverter : JsonConverter<MessageCreatedUpdated>
{
    private static JsonTypeInfo<Discord.Models.Json.MessageCreatedUpdated>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.MessageCreatedUpdated> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateMessageCreatedUpdatedTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateMessageCreatedUpdatedTypeInfoNoConverter(options);
    }

    public override Discord.Models.Json.MessageCreatedUpdated? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        var element = jsonDocument.RootElement;
        var result = element.Deserialize(GetTypeInfoWithoutConverter(options));
        if (result is null)
            return null;
        result.Message = element.Deserialize<Discord.Models.Json.Message>(options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.MessageCreatedUpdated value, JsonSerializerOptions options)
    {
        var node = JsonSerializer.SerializeToNode(value, GetTypeInfoWithoutConverter(options)) as System.Text.Json.Nodes.JsonObject;
        if (node is null)
            return;
        var MessageProp = JsonSerializer.SerializeToNode(value.Message, options) as System.Text.Json.Nodes.JsonObject;
        if (MessageProp is not null)
        {
            foreach (var prop in MessageProp)
                node.Add(prop);
        }

        node.WriteTo(writer, options);
    }
}