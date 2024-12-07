using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedHeartbeatPayloadDataConverter : JsonConverter<HeartbeatPayloadData>
{
    public override Discord.Models.Json.HeartbeatPayloadData? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Discord.Models.Json.HeartbeatPayloadData();
        result.LastSequence = JsonSerializer.Deserialize<int?>(ref reader, options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.HeartbeatPayloadData value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.LastSequence, options);
    }
}