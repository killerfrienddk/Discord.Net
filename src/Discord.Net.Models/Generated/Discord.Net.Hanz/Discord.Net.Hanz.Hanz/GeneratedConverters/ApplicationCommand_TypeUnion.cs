using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ApplicationCommandUnionConverter_Type : JsonConverter<ApplicationCommand>
{
    private static JsonTypeInfo<Discord.Models.Json.ApplicationCommand>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.ApplicationCommand> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateApplicationCommandTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateApplicationCommandTypeInfoNoConverter(options);
    }

    private static readonly Dictionary<int, Type> _lookupTable = new()
    {
        {
            1,
            typeof(Discord.Models.Json.ChatInputApplicationCommand)
        },
        {
            4,
            typeof(Discord.Models.Json.PrimaryEntryPointApplicationCommand)
        }
    };
    public override Discord.Models.Json.ApplicationCommand? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;
        if (!root.TryGetProperty("type", out var delimiterElement))
            return root.Deserialize<Discord.Models.Json.ApplicationCommand>(options);
        var delimiter = delimiterElement.Deserialize<int?>(options);
        if (delimiter is null)
        {
            return null;
        }

        if (!_lookupTable.TryGetValue(delimiter.Value, out var unionType))
            return root.Deserialize(GetTypeInfoWithoutConverter(options));
        return root.Deserialize(unionType, options) as Discord.Models.Json.ApplicationCommand;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.ApplicationCommand value, JsonSerializerOptions options) => JsonSerializer.Serialize(writer, value, GetTypeInfoWithoutConverter(options));
}