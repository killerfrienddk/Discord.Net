using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedThreadMemberUpdatedConverter : JsonConverter<ThreadMemberUpdated>
{
    private static JsonTypeInfo<Discord.Models.Json.ThreadMemberUpdated>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.ThreadMemberUpdated> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateThreadMemberUpdatedTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateThreadMemberUpdatedTypeInfoNoConverter(options);
    }

    public override Discord.Models.Json.ThreadMemberUpdated? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        var element = jsonDocument.RootElement;
        var result = element.Deserialize(GetTypeInfoWithoutConverter(options));
        if (result is null)
            return null;
        result.Member = element.Deserialize<Discord.Models.Json.ThreadMember>(options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.ThreadMemberUpdated value, JsonSerializerOptions options)
    {
        var node = JsonSerializer.SerializeToNode(value, GetTypeInfoWithoutConverter(options)) as System.Text.Json.Nodes.JsonObject;
        if (node is null)
            return;
        var MemberProp = JsonSerializer.SerializeToNode(value.Member, options) as System.Text.Json.Nodes.JsonObject;
        if (MemberProp is not null)
        {
            foreach (var prop in MemberProp)
                node.Add(prop);
        }

        node.WriteTo(writer, options);
    }
}