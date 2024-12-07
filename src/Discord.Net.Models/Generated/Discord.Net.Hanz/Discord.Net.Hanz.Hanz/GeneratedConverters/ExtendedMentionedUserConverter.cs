using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedMentionedUserConverter : JsonConverter<MentionedUser>
{
    private static JsonTypeInfo<Discord.Models.Json.MentionedUser>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.MentionedUser> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateMentionedUserTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateMentionedUserTypeInfoNoConverter(options);
    }

    public override Discord.Models.Json.MentionedUser? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        var element = jsonDocument.RootElement;
        var result = element.Deserialize(GetTypeInfoWithoutConverter(options));
        if (result is null)
            return null;
        result.User = element.Deserialize<Discord.Models.Json.User>(options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.MentionedUser value, JsonSerializerOptions options)
    {
        var node = JsonSerializer.SerializeToNode(value, GetTypeInfoWithoutConverter(options)) as System.Text.Json.Nodes.JsonObject;
        if (node is null)
            return;
        var UserProp = JsonSerializer.SerializeToNode(value.User, options) as System.Text.Json.Nodes.JsonObject;
        if (UserProp is not null)
        {
            foreach (var prop in UserProp)
                node.Add(prop);
        }

        node.WriteTo(writer, options);
    }
}