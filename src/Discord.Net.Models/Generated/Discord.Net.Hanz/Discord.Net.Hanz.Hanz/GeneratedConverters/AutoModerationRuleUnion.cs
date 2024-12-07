using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class AutoModerationRuleUnionConverter : JsonConverter<Discord.Models.Json.AutoModerationRule>
{
    private static JsonTypeInfo<Discord.Models.Json.AutoModerationRule>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.AutoModerationRule> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateAutoModerationRuleTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateAutoModerationRuleTypeInfoNoConverter(options);
    }

    public override Discord.Models.Json.AutoModerationRule? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var element = jsonDoc.RootElement;
        var value = element.Deserialize(GetTypeInfoWithoutConverter(options));
        if (value is null)
            return null;
        if (element.TryGetProperty("trigger_metadata", out var jsonTriggerMetadata))
        {
            value.TriggerMetadata = Optional.Some(DeserializeTriggerMetadata(value, jsonTriggerMetadata, options));
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.AutoModerationRule value, JsonSerializerOptions options)
    {
        var jsonNode = JsonSerializer.SerializeToNode(value, GetTypeInfoWithoutConverter(options)) as System.Text.Json.Nodes.JsonObject;
        if (jsonNode is null)
            return;
        jsonNode.Add("trigger_metadata", JsonSerializer.SerializeToNode(value.TriggerMetadata, options));
        jsonNode.WriteTo(writer, options);
    }

    private static Discord.Models.Json.TriggerMetadata? DeserializeTriggerMetadata(Discord.Models.Json.AutoModerationRule obj, JsonElement element, JsonSerializerOptions options)
    {
        var delimiter = obj.TriggerType;
        return element.Deserialize(delimiter switch
        {
            1 => typeof(Discord.Models.Json.KeywordTriggerMetadata),
            4 => typeof(Discord.Models.Json.KeywordPresetTriggerMetadata),
            5 => typeof(Discord.Models.Json.MentionSpamTriggerMetadata),
            6 => typeof(Discord.Models.Json.MemberProfileTriggerMetadata),
            _ => typeof(Discord.Models.Json.TriggerMetadata)}, options) as Discord.Models.Json.TriggerMetadata;
    }
}