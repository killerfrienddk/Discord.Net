using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedVoiceStateUpdatedConverter : JsonConverter<VoiceStateUpdated>
{
    public override Discord.Models.Json.VoiceStateUpdated? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Discord.Models.Json.VoiceStateUpdated();
        result.VoiceState = JsonSerializer.Deserialize<Discord.Models.Json.VoiceState>(ref reader, options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.VoiceStateUpdated value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.VoiceState, options);
    }
}