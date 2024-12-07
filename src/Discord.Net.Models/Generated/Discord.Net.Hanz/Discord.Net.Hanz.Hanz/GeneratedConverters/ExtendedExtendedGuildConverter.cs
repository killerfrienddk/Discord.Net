using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedExtendedGuildConverter : JsonConverter<ExtendedGuild>
{
    private static JsonTypeInfo<Discord.Models.Json.ExtendedGuild>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.ExtendedGuild> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateExtendedGuildTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateExtendedGuildTypeInfoNoConverter(options);
    }

    public override Discord.Models.Json.ExtendedGuild? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        var element = jsonDocument.RootElement;
        var result = element.Deserialize(GetTypeInfoWithoutConverter(options));
        if (result is null)
            return null;
        result.Guild = element.Deserialize<Discord.Models.Json.Guild>(options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.ExtendedGuild value, JsonSerializerOptions options)
    {
        var node = JsonSerializer.SerializeToNode(value, GetTypeInfoWithoutConverter(options)) as System.Text.Json.Nodes.JsonObject;
        if (node is null)
            return;
        var GuildProp = JsonSerializer.SerializeToNode(value.Guild, options) as System.Text.Json.Nodes.JsonObject;
        if (GuildProp is not null)
        {
            foreach (var prop in GuildProp)
                node.Add(prop);
        }

        node.WriteTo(writer, options);
    }
}