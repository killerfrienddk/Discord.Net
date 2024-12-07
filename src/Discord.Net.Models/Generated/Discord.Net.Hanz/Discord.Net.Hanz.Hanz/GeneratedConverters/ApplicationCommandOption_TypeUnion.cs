using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ApplicationCommandOptionUnionConverter_Type : JsonConverter<ApplicationCommandOption>
{
    private static JsonTypeInfo<Discord.Models.Json.ApplicationCommandOption>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.ApplicationCommandOption> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateApplicationCommandOptionTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateApplicationCommandOptionTypeInfoNoConverter(options);
    }

    private static readonly Dictionary<int, Type> _lookupTable = new()
    {
        {
            11,
            typeof(Discord.Models.Json.AttachmentApplicationCommandOption)
        },
        {
            5,
            typeof(Discord.Models.Json.BooleanApplicationCommandOption)
        },
        {
            7,
            typeof(Discord.Models.Json.ChannelApplicationCommandOption)
        },
        {
            4,
            typeof(Discord.Models.Json.IntegerApplicationCommandOption)
        },
        {
            9,
            typeof(Discord.Models.Json.MentionableApplicationCommandOption)
        },
        {
            10,
            typeof(Discord.Models.Json.NumberApplicationCommandOption)
        },
        {
            8,
            typeof(Discord.Models.Json.RoleApplicationCommandOption)
        },
        {
            3,
            typeof(Discord.Models.Json.StringApplicationCommandOption)
        },
        {
            1,
            typeof(Discord.Models.Json.SubCommandApplicationCommandOption)
        },
        {
            2,
            typeof(Discord.Models.Json.SubCommandGroupApplicationCommandOption)
        },
        {
            6,
            typeof(Discord.Models.Json.UserApplicationCommandOption)
        }
    };
    public override Discord.Models.Json.ApplicationCommandOption? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;
        if (!root.TryGetProperty("type", out var delimiterElement))
            return root.Deserialize<Discord.Models.Json.ApplicationCommandOption>(options);
        var delimiter = delimiterElement.Deserialize<int>(options);
        if (!_lookupTable.TryGetValue(delimiter, out var unionType))
            return root.Deserialize(GetTypeInfoWithoutConverter(options));
        return root.Deserialize(unionType, options) as Discord.Models.Json.ApplicationCommandOption;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.ApplicationCommandOption value, JsonSerializerOptions options) => JsonSerializer.Serialize(writer, value, GetTypeInfoWithoutConverter(options));
}