using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class SoundboardSoundUnionConverter_GuildId : JsonConverter<SoundboardSound>
{
    private static JsonTypeInfo<Discord.Models.Json.SoundboardSound>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.SoundboardSound> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateSoundboardSoundTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateSoundboardSoundTypeInfoNoConverter(options);
    }

    public override Discord.Models.Json.SoundboardSound? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;
        if (!root.TryGetProperty("guild_id", out var delimiterElement))
            return root.Deserialize<Discord.Models.Json.SoundboardSound>(options);
        return root.Deserialize<Discord.Models.Json.GuildSoundboardSound>(options);
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.SoundboardSound value, JsonSerializerOptions options) => JsonSerializer.Serialize(writer, value, GetTypeInfoWithoutConverter(options));
}