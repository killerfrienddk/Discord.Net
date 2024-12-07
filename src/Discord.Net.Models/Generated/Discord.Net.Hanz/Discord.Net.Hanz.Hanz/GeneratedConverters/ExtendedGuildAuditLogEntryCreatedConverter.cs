using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedGuildAuditLogEntryCreatedConverter : JsonConverter<GuildAuditLogEntryCreated>
{
    private static JsonTypeInfo<Discord.Models.Json.GuildAuditLogEntryCreated>? _typeInfo;
    private static JsonTypeInfo<Discord.Models.Json.GuildAuditLogEntryCreated> GetTypeInfoWithoutConverter(JsonSerializerOptions options)
    {
        if (_typeInfo is not null)
            return _typeInfo;
        if (options.TypeInfoResolver is ModelJsonContext modelJsonContext)
            return _typeInfo = modelJsonContext.CreateGuildAuditLogEntryCreatedTypeInfoNoConverter(options);
        return _typeInfo = options.TypeInfoResolverChain.OfType<ModelJsonContext>().First().CreateGuildAuditLogEntryCreatedTypeInfoNoConverter(options);
    }

    public override Discord.Models.Json.GuildAuditLogEntryCreated? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        var element = jsonDocument.RootElement;
        var result = element.Deserialize(GetTypeInfoWithoutConverter(options));
        if (result is null)
            return null;
        result.AuditLogEntry = element.Deserialize<Discord.Models.Json.AuditLogEntry>(options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.GuildAuditLogEntryCreated value, JsonSerializerOptions options)
    {
        var node = JsonSerializer.SerializeToNode(value, GetTypeInfoWithoutConverter(options)) as System.Text.Json.Nodes.JsonObject;
        if (node is null)
            return;
        var AuditLogEntryProp = JsonSerializer.SerializeToNode(value.AuditLogEntry, options) as System.Text.Json.Nodes.JsonObject;
        if (AuditLogEntryProp is not null)
        {
            foreach (var prop in AuditLogEntryProp)
                node.Add(prop);
        }

        node.WriteTo(writer, options);
    }
}