using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedPresenceUpdatedConverter : JsonConverter<PresenceUpdated>
{
    public override Discord.Models.Json.PresenceUpdated? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Discord.Models.Json.PresenceUpdated();
        result.Presence = JsonSerializer.Deserialize<Discord.Models.Json.Presence>(ref reader, options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.PresenceUpdated value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.Presence, options);
    }
}