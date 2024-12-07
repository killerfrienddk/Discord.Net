using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedGuildUpdatedConverter : JsonConverter<GuildUpdated>
{
    public override Discord.Models.Json.GuildUpdated? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Discord.Models.Json.GuildUpdated();
        result.Guild = JsonSerializer.Deserialize<Discord.Models.Json.Guild>(ref reader, options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.GuildUpdated value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.Guild, options);
    }
}