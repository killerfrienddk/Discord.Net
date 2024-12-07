using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedInvalidSessionPayloadDataConverter : JsonConverter<InvalidSessionPayloadData>
{
    public override Discord.Models.Json.InvalidSessionPayloadData? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Discord.Models.Json.InvalidSessionPayloadData();
        result.CanResume = JsonSerializer.Deserialize<bool>(ref reader, options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.InvalidSessionPayloadData value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.CanResume, options);
    }
}