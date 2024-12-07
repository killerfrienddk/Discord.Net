using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class WebhookUnionConverter_Type : JsonConverter<Webhook>
{
    private static JsonTypeInfo<Discord.Models.Json.Webhook>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.Webhook> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateWebhookTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateWebhookTypeInfoNoConverter(options);
    }

    private static readonly Dictionary<int, Type> _lookupTable = new()
    {
        {
            2,
            typeof(Discord.Models.Json.ChannelFollowerWebhook)
        },
        {
            1,
            typeof(Discord.Models.Json.IncomingWebhook)
        }
    };
    public override Discord.Models.Json.Webhook? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;
        if (!root.TryGetProperty("type", out var delimiterElement))
            return root.Deserialize<Discord.Models.Json.Webhook>(options);
        var delimiter = delimiterElement.Deserialize<int>(options);
        if (!_lookupTable.TryGetValue(delimiter, out var unionType))
            return root.Deserialize(GetTypeInfoWithoutConverter(options));
        return root.Deserialize(unionType, options) as Discord.Models.Json.Webhook;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.Webhook value, JsonSerializerOptions options) => JsonSerializer.Serialize(writer, value, GetTypeInfoWithoutConverter(options));
}