using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ThreadableChannelBaseUnionConverter_Type : JsonConverter<ThreadableChannelBase>
{
    private static JsonTypeInfo<Discord.Models.Json.ThreadableChannelBase>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.ThreadableChannelBase> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateThreadableChannelBaseTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateThreadableChannelBaseTypeInfoNoConverter(options);
    }

    private static readonly Dictionary<uint, Type> _lookupTable = new()
    {
        {
            5U,
            typeof(Discord.Models.Json.GuildAnnouncementChannel)
        },
        {
            15U,
            typeof(Discord.Models.Json.GuildForumChannel)
        },
        {
            16U,
            typeof(Discord.Models.Json.GuildMediaChannel)
        },
        {
            0U,
            typeof(Discord.Models.Json.GuildTextChannel)
        }
    };
    public override Discord.Models.Json.ThreadableChannelBase? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;
        if (!root.TryGetProperty("type", out var delimiterElement))
            return root.Deserialize<Discord.Models.Json.ThreadableChannelBase>(options);
        var delimiter = delimiterElement.Deserialize<uint>(options);
        if (!_lookupTable.TryGetValue(delimiter, out var unionType))
            return root.Deserialize(GetTypeInfoWithoutConverter(options));
        return root.Deserialize(unionType, options) as Discord.Models.Json.ThreadableChannelBase;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.ThreadableChannelBase value, JsonSerializerOptions options) => JsonSerializer.Serialize(writer, value, GetTypeInfoWithoutConverter(options));
}