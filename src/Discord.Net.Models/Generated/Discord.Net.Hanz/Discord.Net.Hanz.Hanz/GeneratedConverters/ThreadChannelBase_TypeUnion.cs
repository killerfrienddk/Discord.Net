using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ThreadChannelBaseUnionConverter_Type : JsonConverter<ThreadChannelBase>
{
    private static JsonTypeInfo<Discord.Models.Json.ThreadChannelBase>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.ThreadChannelBase> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateThreadChannelBaseTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateThreadChannelBaseTypeInfoNoConverter(options);
    }

    private static readonly Dictionary<uint, Type> _lookupTable = new()
    {
        {
            10U,
            typeof(Discord.Models.Json.AnnouncementThreadChannel)
        },
        {
            12U,
            typeof(Discord.Models.Json.PrivateThreadChannel)
        },
        {
            11U,
            typeof(Discord.Models.Json.PublicThreadChannel)
        }
    };
    public override Discord.Models.Json.ThreadChannelBase? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;
        if (!root.TryGetProperty("type", out var delimiterElement))
            return null;
        var delimiter = delimiterElement.Deserialize<uint>(options);
        if (!_lookupTable.TryGetValue(delimiter, out var unionType))
            return root.Deserialize(GetTypeInfoWithoutConverter(options));
        return root.Deserialize(unionType, options) as Discord.Models.Json.ThreadChannelBase;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.ThreadChannelBase value, JsonSerializerOptions options) => JsonSerializer.Serialize(writer, value, GetTypeInfoWithoutConverter(options));
}