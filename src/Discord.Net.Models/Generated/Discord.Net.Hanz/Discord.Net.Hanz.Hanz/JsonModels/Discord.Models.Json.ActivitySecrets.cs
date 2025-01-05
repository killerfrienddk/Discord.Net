using System.Text.Json.Serialization.Metadata;
using System.Text.Json.Serialization;
using System.Text.Json;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class ActivitySecrets : 
    ISTJModel<Discord.Models.Json.ActivitySecrets>
{
    private static readonly JsonEncodedText __JsonPropNameMatch = JsonEncodedText.Encode("match");
    private static readonly JsonEncodedText __JsonPropNameJoin = JsonEncodedText.Encode("join");
    private static readonly JsonEncodedText __JsonPropNameSpectate = JsonEncodedText.Encode("spectate");


    internal static JsonTypeInfo<Discord.Models.Json.ActivitySecrets> CreateJsonTypeInfo(DiscordModelResolver resolver) => JsonMetadataServices.CreateObjectInfo<Discord.Models.Json.ActivitySecrets>(resolver.Options, new JsonObjectInfoValues<Discord.Models.Json.ActivitySecrets>
    {
        ObjectCreator = () => new Discord.Models.Json.ActivitySecrets(),
        ObjectWithParameterizedConstructorCreator = null,
        PropertyMetadataInitializer = _ => Discord.Models.Json.ActivitySecrets.GetPropertyInfos(resolver.Options),
        ConstructorParameterMetadataInitializer = null,
        SerializeHandler = (writer, model) => Discord.Models.Json.ActivitySecrets.Serialize(writer, model, resolver)
    });

    internal static void Serialize(
        Utf8JsonWriter writer,
        Discord.Models.Json.ActivitySecrets? model,
        DiscordModelResolver resolver
    )
    {
        if(model is null)
        {
            writer.WriteNullValue();
            return;
        }
        
        writer.WriteStartObject();
        
        // "Match" of type "Discord.Optional<string>"
        if(model.Match.IsSpecified)
        {
            writer.WriteString(__JsonPropNameMatch, model.Match.Value);
        }
        
        // "Join" of type "Discord.Optional<string>"
        if(model.Join.IsSpecified)
        {
            writer.WriteString(__JsonPropNameJoin, model.Join.Value);
        }
        
        // "Spectate" of type "Discord.Optional<string>"
        if(model.Spectate.IsSpecified)
        {
            writer.WriteString(__JsonPropNameSpectate, model.Spectate.Value);
        }
        
        writer.WriteEndObject();
    }
    

    internal static JsonPropertyInfo[] GetPropertyInfos(JsonSerializerOptions options)
    {
        var props = new JsonPropertyInfo[3];
        props[0] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<string>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.ActivitySecrets),
            Getter = static obj => ((Discord.Models.Json.ActivitySecrets)obj).Match,
            Setter = static (obj, value) => ((Discord.Models.Json.ActivitySecrets)obj).Match = value!,
            PropertyName = "Match",
            JsonPropertyName = "match",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[1] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<string>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.ActivitySecrets),
            Getter = static obj => ((Discord.Models.Json.ActivitySecrets)obj).Join,
            Setter = static (obj, value) => ((Discord.Models.Json.ActivitySecrets)obj).Join = value!,
            PropertyName = "Join",
            JsonPropertyName = "join",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[2] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<string>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.ActivitySecrets),
            Getter = static obj => ((Discord.Models.Json.ActivitySecrets)obj).Spectate,
            Setter = static (obj, value) => ((Discord.Models.Json.ActivitySecrets)obj).Spectate = value!,
            PropertyName = "Spectate",
            JsonPropertyName = "spectate",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        return props;
    }
    

    static JsonTypeInfo<Discord.Models.Json.ActivitySecrets> ISTJModel<Discord.Models.Json.ActivitySecrets>.CreateJsonTypeInfo(DiscordModelResolver resolver) => CreateJsonTypeInfo(resolver);

    static void ISTJModel<Discord.Models.Json.ActivitySecrets>.Serialize(
        Utf8JsonWriter writer,
        Discord.Models.Json.ActivitySecrets? model,
        DiscordModelResolver resolver
    ) => Serialize(writer, model, resolver);
}
