using System.Text.Json.Serialization.Metadata;
using System.Text.Json.Serialization;
using System.Text.Json;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class ActivityButton : 
    ISTJModel<Discord.Models.Json.ActivityButton>
{
    private static readonly JsonEncodedText __JsonPropNameLabel = JsonEncodedText.Encode("label");
    private static readonly JsonEncodedText __JsonPropNameUrl = JsonEncodedText.Encode("url");


    internal static JsonTypeInfo<Discord.Models.Json.ActivityButton> CreateJsonTypeInfo(DiscordModelResolver resolver) => JsonMetadataServices.CreateObjectInfo<Discord.Models.Json.ActivityButton>(resolver.Options, new JsonObjectInfoValues<Discord.Models.Json.ActivityButton>
    {
        ObjectCreator = null,
        ObjectWithParameterizedConstructorCreator = static args => new Discord.Models.Json.ActivityButton{ Label = (string)args[0], Url = (string)args[1] },
        PropertyMetadataInitializer = _ => Discord.Models.Json.ActivityButton.GetPropertyInfos(resolver.Options),
        ConstructorParameterMetadataInitializer = Discord.Models.Json.ActivityButton.GetCtorParamsInfo,
        SerializeHandler = (writer, model) => Discord.Models.Json.ActivityButton.Serialize(writer, model, resolver)
    });

    internal static void Serialize(
        Utf8JsonWriter writer,
        Discord.Models.Json.ActivityButton? model,
        DiscordModelResolver resolver
    )
    {
        if(model is null)
        {
            writer.WriteNullValue();
            return;
        }
        
        writer.WriteStartObject();
        
        // "Label" of type "string"
        writer.WriteString(__JsonPropNameLabel, model.Label);
        
        // "Url" of type "string"
        writer.WriteString(__JsonPropNameUrl, model.Url);
        
        writer.WriteEndObject();
    }
    

    internal static JsonPropertyInfo[] GetPropertyInfos(JsonSerializerOptions options)
    {
        var props = new JsonPropertyInfo[2];
        props[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.ActivityButton),
            Getter = static obj => ((Discord.Models.Json.ActivityButton)obj).Label,
            Setter = static (obj, value) => ((Discord.Models.Json.ActivityButton)obj).Label = value!,
            PropertyName = "Label",
            JsonPropertyName = "label",
            IgnoreCondition = null
        });
        props[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.ActivityButton),
            Getter = static obj => ((Discord.Models.Json.ActivityButton)obj).Url,
            Setter = static (obj, value) => ((Discord.Models.Json.ActivityButton)obj).Url = value!,
            PropertyName = "Url",
            JsonPropertyName = "url",
            IgnoreCondition = null
        });
        return props;
    }
    

    static JsonTypeInfo<Discord.Models.Json.ActivityButton> ISTJModel<Discord.Models.Json.ActivityButton>.CreateJsonTypeInfo(DiscordModelResolver resolver) => CreateJsonTypeInfo(resolver);

    static void ISTJModel<Discord.Models.Json.ActivityButton>.Serialize(
        Utf8JsonWriter writer,
        Discord.Models.Json.ActivityButton? model,
        DiscordModelResolver resolver
    ) => Serialize(writer, model, resolver);

    internal static JsonParameterInfoValues[] GetCtorParamsInfo()
    {
        var parameters = new JsonParameterInfoValues[2];
        
        parameters[0] = new()
        {
            Name = "Label",
            ParameterType = typeof(string),
            Position = 0
        };
        parameters[1] = new()
        {
            Name = "Url",
            ParameterType = typeof(string),
            Position = 1
        };
        
        
        return parameters;
    }
    
}
