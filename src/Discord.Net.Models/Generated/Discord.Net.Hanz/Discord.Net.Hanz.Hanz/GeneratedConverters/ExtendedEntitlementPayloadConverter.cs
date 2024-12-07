using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedEntitlementPayloadConverter : JsonConverter<EntitlementPayload>
{
    public override Discord.Models.Json.EntitlementPayload? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Discord.Models.Json.EntitlementPayload();
        result.Entitlement = JsonSerializer.Deserialize<Discord.Models.Json.Entitlement>(ref reader, options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.EntitlementPayload value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.Entitlement, options);
    }
}