using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class InteractionUnionConverter : JsonConverter<Discord.Models.Json.Interaction>
{
    private static JsonTypeInfo<Discord.Models.Json.Interaction>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.Interaction> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateInteractionTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateInteractionTypeInfoNoConverter(options);
    }

    public override Discord.Models.Json.Interaction? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var element = jsonDoc.RootElement;
        var value = element.Deserialize(GetTypeInfoWithoutConverter(options));
        if (value is null)
            return null;
        if (element.TryGetProperty("data", out var jsonData))
        {
            value.Data = Optional.Some(DeserializeData(value, jsonData, options)!);
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.Interaction value, JsonSerializerOptions options)
    {
        var jsonNode = JsonSerializer.SerializeToNode(value, GetTypeInfoWithoutConverter(options)) as System.Text.Json.Nodes.JsonObject;
        if (jsonNode is null)
            return;
        jsonNode.Add("data", JsonSerializer.SerializeToNode(value.Data, options));
        jsonNode.WriteTo(writer, options);
    }

    private static Discord.Models.Json.InteractionData? DeserializeData(Discord.Models.Json.Interaction obj, JsonElement element, JsonSerializerOptions options)
    {
        var delimiter = obj.Type;
        return element.Deserialize(delimiter switch
        {
            2 or 4 => typeof(Discord.Models.Json.ApplicationCommandInteractionData),
            3 => typeof(Discord.Models.Json.MessageComponentData),
            5 => typeof(Discord.Models.Json.ModalSubmitData),
            _ => typeof(Discord.Models.Json.InteractionData)}, options) as Discord.Models.Json.InteractionData;
    }
}