using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedStageInstancePayloadConverter : JsonConverter<StageInstancePayload>
{
    public override Discord.Models.Json.StageInstancePayload? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Discord.Models.Json.StageInstancePayload();
        result.StageInstance = JsonSerializer.Deserialize<Discord.Models.Json.StageInstance>(ref reader, options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.StageInstancePayload value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.StageInstance, options);
    }
}