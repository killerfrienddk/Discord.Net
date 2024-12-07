using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class EmoteUnionConverter_Id : JsonConverter<Emote>
{
    private static JsonTypeInfo<Discord.Models.Json.Emote>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.Emote> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateEmoteTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateEmoteTypeInfoNoConverter(options);
    }

    public override Discord.Models.Json.Emote? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;
        if (!root.TryGetProperty("id", out var delimiterElement))
            return root.Deserialize<Discord.Models.Json.Emoji>(options);
        return root.Deserialize<Discord.Models.Json.CustomEmote>(options);
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.Emote value, JsonSerializerOptions options) => JsonSerializer.Serialize(writer, value, GetTypeInfoWithoutConverter(options));
}