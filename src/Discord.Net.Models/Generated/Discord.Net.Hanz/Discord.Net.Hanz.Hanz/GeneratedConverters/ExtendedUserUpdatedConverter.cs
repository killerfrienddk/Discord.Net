using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedUserUpdatedConverter : JsonConverter<UserUpdated>
{
    public override Discord.Models.Json.UserUpdated? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Discord.Models.Json.UserUpdated();
        result.User = JsonSerializer.Deserialize<Discord.Models.Json.SelfUser>(ref reader, options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.UserUpdated value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.User, options);
    }
}