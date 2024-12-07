using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class GuildCreatedUnionConverter_Unavailable : JsonConverter<GuildCreated>
{
    private static JsonTypeInfo<Discord.Models.Json.GuildCreated>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.GuildCreated> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateGuildCreatedTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateGuildCreatedTypeInfoNoConverter(options);
    }

    private static readonly Dictionary<bool, Type> _lookupTable = new()
    {
        {
            false,
            typeof(Discord.Models.Json.ExtendedGuild)
        },
        {
            true,
            typeof(Discord.Models.Json.UnavailableGuild)
        }
    };
    public override Discord.Models.Json.GuildCreated? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;
        if (!root.TryGetProperty("unavailable", out var delimiterElement))
            return null;
        var delimiter = delimiterElement.Deserialize<bool>(options);
        if (!_lookupTable.TryGetValue(delimiter, out var unionType))
            return root.Deserialize(GetTypeInfoWithoutConverter(options));
        return root.Deserialize(unionType, options) as Discord.Models.Json.GuildCreated;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.GuildCreated value, JsonSerializerOptions options) => JsonSerializer.Serialize(writer, value, GetTypeInfoWithoutConverter(options));
}