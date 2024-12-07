using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedGuildScheduledEventPayloadConverter : JsonConverter<GuildScheduledEventPayload>
{
    public override Discord.Models.Json.GuildScheduledEventPayload? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Discord.Models.Json.GuildScheduledEventPayload();
        result.Event = JsonSerializer.Deserialize<Discord.Models.Json.GuildScheduledEvent>(ref reader, options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.GuildScheduledEventPayload value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.Event, options);
    }
}