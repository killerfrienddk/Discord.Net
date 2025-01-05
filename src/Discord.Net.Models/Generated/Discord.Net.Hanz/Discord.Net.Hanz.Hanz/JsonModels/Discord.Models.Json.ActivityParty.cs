using System.Text.Json.Serialization.Metadata;
using System.Text.Json.Serialization;
using System.Text.Json;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class ActivityParty : 
    ISTJModel<Discord.Models.Json.ActivityParty>
{
    private static readonly JsonEncodedText __JsonPropNameId = JsonEncodedText.Encode("id");
    private static readonly JsonEncodedText __JsonPropNameSize = JsonEncodedText.Encode("size");


    internal static JsonTypeInfo<Discord.Models.Json.ActivityParty> CreateJsonTypeInfo(DiscordModelResolver resolver) => JsonMetadataServices.CreateObjectInfo<Discord.Models.Json.ActivityParty>(resolver.Options, new JsonObjectInfoValues<Discord.Models.Json.ActivityParty>
    {
        ObjectCreator = () => new Discord.Models.Json.ActivityParty(),
        ObjectWithParameterizedConstructorCreator = null,
        PropertyMetadataInitializer = _ => Discord.Models.Json.ActivityParty.GetPropertyInfos(resolver.Options),
        ConstructorParameterMetadataInitializer = null,
        SerializeHandler = (writer, model) => Discord.Models.Json.ActivityParty.Serialize(writer, model, resolver)
    });

    internal static void Serialize(
        Utf8JsonWriter writer,
        Discord.Models.Json.ActivityParty? model,
        DiscordModelResolver resolver
    )
    {
        if(model is null)
        {
            writer.WriteNullValue();
            return;
        }
        
        writer.WriteStartObject();
        
        // "Id" of type "Discord.Optional<string>"
        if(model.Id.IsSpecified)
        {
            writer.WriteString(__JsonPropNameId, model.Id.Value);
        }
        
        // "Size" of type "Discord.Optional<System.Collections.Generic.IReadOnlyCollection<int>>"
        if(model.Size.IsSpecified)
        {
            writer.WritePropertyName(__JsonPropNameSize);
            JsonSerializer.Serialize(writer, model.Size.Value, resolver.Options);
        }
        
        writer.WriteEndObject();
    }
    

    internal static JsonPropertyInfo[] GetPropertyInfos(JsonSerializerOptions options)
    {
        var props = new JsonPropertyInfo[2];
        props[0] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<string>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.ActivityParty),
            Getter = static obj => ((Discord.Models.Json.ActivityParty)obj).Id,
            Setter = static (obj, value) => ((Discord.Models.Json.ActivityParty)obj).Id = value!,
            PropertyName = "Id",
            JsonPropertyName = "id",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[1] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<System.Collections.Generic.IReadOnlyCollection<int>>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.ActivityParty),
            Getter = static obj => ((Discord.Models.Json.ActivityParty)obj).Size,
            Setter = static (obj, value) => ((Discord.Models.Json.ActivityParty)obj).Size = value!,
            PropertyName = "Size",
            JsonPropertyName = "size",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        return props;
    }
    

    static JsonTypeInfo<Discord.Models.Json.ActivityParty> ISTJModel<Discord.Models.Json.ActivityParty>.CreateJsonTypeInfo(DiscordModelResolver resolver) => CreateJsonTypeInfo(resolver);

    static void ISTJModel<Discord.Models.Json.ActivityParty>.Serialize(
        Utf8JsonWriter writer,
        Discord.Models.Json.ActivityParty? model,
        DiscordModelResolver resolver
    ) => Serialize(writer, model, resolver);
}
