using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedApplicationCommandPermissionUpdatedConverter : JsonConverter<ApplicationCommandPermissionUpdated>
{
    public override Discord.Models.Json.ApplicationCommandPermissionUpdated? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Discord.Models.Json.ApplicationCommandPermissionUpdated();
        result.GuildApplicationCommandPermission = JsonSerializer.Deserialize<Discord.Models.Json.GuildApplicationCommandPermission>(ref reader, options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.ApplicationCommandPermissionUpdated value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.GuildApplicationCommandPermission, options);
    }
}