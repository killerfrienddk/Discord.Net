using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class AutoModerationActionUnionConverter : JsonConverter<Discord.Models.Json.AutoModerationAction>
{
    private static JsonTypeInfo<Discord.Models.Json.AutoModerationAction>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.AutoModerationAction> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateAutoModerationActionTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateAutoModerationActionTypeInfoNoConverter(options);
    }

    public override Discord.Models.Json.AutoModerationAction? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var element = jsonDoc.RootElement;
        var value = element.Deserialize(GetTypeInfoWithoutConverter(options));
        if (value is null)
            return null;
        if (element.TryGetProperty("metadata", out var jsonMetadata))
        {
            value.Metadata = Optional.Some(DeserializeMetadata(value, jsonMetadata, options)!);
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.AutoModerationAction value, JsonSerializerOptions options)
    {
        var jsonNode = JsonSerializer.SerializeToNode(value, GetTypeInfoWithoutConverter(options)) as System.Text.Json.Nodes.JsonObject;
        if (jsonNode is null)
            return;
        jsonNode.Add("metadata", JsonSerializer.SerializeToNode(value.Metadata, options));
        jsonNode.WriteTo(writer, options);
    }

    private static Discord.Models.Json.ActionMetadata? DeserializeMetadata(Discord.Models.Json.AutoModerationAction obj, JsonElement element, JsonSerializerOptions options)
    {
        var delimiter = obj.Type;
        return element.Deserialize(delimiter switch
        {
            1 => typeof(Discord.Models.Json.BlockMessageMetadata),
            2 => typeof(Discord.Models.Json.SendAlertMessageMetadata),
            3 => typeof(Discord.Models.Json.TimeoutMetadata),
            _ => typeof(Discord.Models.Json.ActionMetadata)}, options) as Discord.Models.Json.ActionMetadata;
    }
}