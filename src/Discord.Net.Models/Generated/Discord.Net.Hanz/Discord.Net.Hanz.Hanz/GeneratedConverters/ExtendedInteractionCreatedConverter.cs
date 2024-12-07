using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Converters;

public sealed class ExtendedInteractionCreatedConverter : JsonConverter<InteractionCreated>
{
    public override Discord.Models.Json.InteractionCreated? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Discord.Models.Json.InteractionCreated();
        result.Interaction = JsonSerializer.Deserialize<Discord.Models.Json.Interaction>(ref reader, options)!;
        return result;
    }

    public override void Write(Utf8JsonWriter writer, Discord.Models.Json.InteractionCreated value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.Interaction, options);
    }
}