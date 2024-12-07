using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedAutoModerationRulePayloadConverter : JsonConverter<AutoModerationRulePayload>
{
    public override Discord.Models.Json.AutoModerationRulePayload? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Discord.Models.Json.AutoModerationRulePayload();
        result.AutoModerationRule = JsonSerializer.Deserialize<Discord.Models.Json.AutoModerationRule>(ref reader, options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.AutoModerationRulePayload value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.AutoModerationRule, options);
    }
}