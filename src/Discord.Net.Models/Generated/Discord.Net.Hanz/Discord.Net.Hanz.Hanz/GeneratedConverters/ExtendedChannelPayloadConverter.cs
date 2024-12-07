using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedChannelPayloadConverter : JsonConverter<ChannelPayload>
{
    public override Discord.Models.Json.ChannelPayload? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Discord.Models.Json.ChannelPayload();
        result.Channel = JsonSerializer.Deserialize<Discord.Models.Json.Channel>(ref reader, options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.ChannelPayload value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.Channel, options);
    }
}