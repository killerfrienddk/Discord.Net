using System.Text.Json.Serialization.Metadata;
using System.Text.Json.Serialization;
using System.Text.Json;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class ActivityTimestamps : 
    ISTJModel<Discord.Models.Json.ActivityTimestamps>
{
    private static readonly JsonEncodedText __JsonPropNameStart = JsonEncodedText.Encode("start");
    private static readonly JsonEncodedText __JsonPropNameEnd = JsonEncodedText.Encode("end");


    internal static JsonTypeInfo<Discord.Models.Json.ActivityTimestamps> CreateJsonTypeInfo(DiscordModelResolver resolver) => JsonMetadataServices.CreateObjectInfo<Discord.Models.Json.ActivityTimestamps>(resolver.Options, new JsonObjectInfoValues<Discord.Models.Json.ActivityTimestamps>
    {
        ObjectCreator = () => new Discord.Models.Json.ActivityTimestamps(),
        ObjectWithParameterizedConstructorCreator = null,
        PropertyMetadataInitializer = _ => Discord.Models.Json.ActivityTimestamps.GetPropertyInfos(resolver.Options),
        ConstructorParameterMetadataInitializer = null,
        SerializeHandler = (writer, model) => Discord.Models.Json.ActivityTimestamps.Serialize(writer, model, resolver)
    });

    internal static void Serialize(
        Utf8JsonWriter writer,
        Discord.Models.Json.ActivityTimestamps? model,
        DiscordModelResolver resolver
    )
    {
        if(model is null)
        {
            writer.WriteNullValue();
            return;
        }
        
        writer.WriteStartObject();
        
        // "Start" of type "Discord.Optional<System.DateTimeOffset>"
        if(model.Start.IsSpecified)
        {
            writer.WritePropertyName(__JsonPropNameStart);
            JsonSerializer.Serialize(writer, model.Start.Value, resolver.Options);
        }
        
        // "End" of type "Discord.Optional<System.DateTimeOffset>"
        if(model.End.IsSpecified)
        {
            writer.WritePropertyName(__JsonPropNameEnd);
            JsonSerializer.Serialize(writer, model.End.Value, resolver.Options);
        }
        
        writer.WriteEndObject();
    }
    

    internal static JsonPropertyInfo[] GetPropertyInfos(JsonSerializerOptions options)
    {
        var props = new JsonPropertyInfo[2];
        props[0] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<System.DateTimeOffset>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.ActivityTimestamps),
            Getter = static obj => ((Discord.Models.Json.ActivityTimestamps)obj).Start,
            Setter = static (obj, value) => ((Discord.Models.Json.ActivityTimestamps)obj).Start = value!,
            PropertyName = "Start",
            JsonPropertyName = "start",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[1] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<System.DateTimeOffset>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.ActivityTimestamps),
            Getter = static obj => ((Discord.Models.Json.ActivityTimestamps)obj).End,
            Setter = static (obj, value) => ((Discord.Models.Json.ActivityTimestamps)obj).End = value!,
            PropertyName = "End",
            JsonPropertyName = "end",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        return props;
    }
    

    static JsonTypeInfo<Discord.Models.Json.ActivityTimestamps> ISTJModel<Discord.Models.Json.ActivityTimestamps>.CreateJsonTypeInfo(DiscordModelResolver resolver) => CreateJsonTypeInfo(resolver);

    static void ISTJModel<Discord.Models.Json.ActivityTimestamps>.Serialize(
        Utf8JsonWriter writer,
        Discord.Models.Json.ActivityTimestamps? model,
        DiscordModelResolver resolver
    ) => Serialize(writer, model, resolver);
}
