using System.Text.Json.Serialization.Metadata;
using System.Text.Json.Serialization;
using System.Text.Json;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class ActivityAssets : 
    ISTJModel<Discord.Models.Json.ActivityAssets>
{
    private static readonly JsonEncodedText __JsonPropNameSmallText = JsonEncodedText.Encode("small_text");
    private static readonly JsonEncodedText __JsonPropNameSmallImage = JsonEncodedText.Encode("small_image");
    private static readonly JsonEncodedText __JsonPropNameLargeText = JsonEncodedText.Encode("large_text");
    private static readonly JsonEncodedText __JsonPropNameLargeImage = JsonEncodedText.Encode("large_image");


    internal static JsonTypeInfo<Discord.Models.Json.ActivityAssets> CreateJsonTypeInfo(DiscordModelResolver resolver) => JsonMetadataServices.CreateObjectInfo<Discord.Models.Json.ActivityAssets>(resolver.Options, new JsonObjectInfoValues<Discord.Models.Json.ActivityAssets>
    {
        ObjectCreator = () => new Discord.Models.Json.ActivityAssets(),
        ObjectWithParameterizedConstructorCreator = null,
        PropertyMetadataInitializer = _ => Discord.Models.Json.ActivityAssets.GetPropertyInfos(resolver.Options),
        ConstructorParameterMetadataInitializer = null,
        SerializeHandler = (writer, model) => Discord.Models.Json.ActivityAssets.Serialize(writer, model, resolver)
    });

    internal static void Serialize(
        Utf8JsonWriter writer,
        Discord.Models.Json.ActivityAssets? model,
        DiscordModelResolver resolver
    )
    {
        if(model is null)
        {
            writer.WriteNullValue();
            return;
        }
        
        writer.WriteStartObject();
        
        // "SmallText" of type "Discord.Optional<string>"
        if(model.SmallText.IsSpecified)
        {
            writer.WriteString(__JsonPropNameSmallText, model.SmallText.Value);
        }
        
        // "SmallImage" of type "Discord.Optional<string>"
        if(model.SmallImage.IsSpecified)
        {
            writer.WriteString(__JsonPropNameSmallImage, model.SmallImage.Value);
        }
        
        // "LargeText" of type "Discord.Optional<string>"
        if(model.LargeText.IsSpecified)
        {
            writer.WriteString(__JsonPropNameLargeText, model.LargeText.Value);
        }
        
        // "LargeImage" of type "Discord.Optional<string>"
        if(model.LargeImage.IsSpecified)
        {
            writer.WriteString(__JsonPropNameLargeImage, model.LargeImage.Value);
        }
        
        writer.WriteEndObject();
    }
    

    internal static JsonPropertyInfo[] GetPropertyInfos(JsonSerializerOptions options)
    {
        var props = new JsonPropertyInfo[4];
        props[0] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<string>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.ActivityAssets),
            Getter = static obj => ((Discord.Models.Json.ActivityAssets)obj).SmallText,
            Setter = static (obj, value) => ((Discord.Models.Json.ActivityAssets)obj).SmallText = value!,
            PropertyName = "SmallText",
            JsonPropertyName = "small_text",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[1] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<string>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.ActivityAssets),
            Getter = static obj => ((Discord.Models.Json.ActivityAssets)obj).SmallImage,
            Setter = static (obj, value) => ((Discord.Models.Json.ActivityAssets)obj).SmallImage = value!,
            PropertyName = "SmallImage",
            JsonPropertyName = "small_image",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[2] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<string>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.ActivityAssets),
            Getter = static obj => ((Discord.Models.Json.ActivityAssets)obj).LargeText,
            Setter = static (obj, value) => ((Discord.Models.Json.ActivityAssets)obj).LargeText = value!,
            PropertyName = "LargeText",
            JsonPropertyName = "large_text",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[3] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<string>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.ActivityAssets),
            Getter = static obj => ((Discord.Models.Json.ActivityAssets)obj).LargeImage,
            Setter = static (obj, value) => ((Discord.Models.Json.ActivityAssets)obj).LargeImage = value!,
            PropertyName = "LargeImage",
            JsonPropertyName = "large_image",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        return props;
    }
    

    static JsonTypeInfo<Discord.Models.Json.ActivityAssets> ISTJModel<Discord.Models.Json.ActivityAssets>.CreateJsonTypeInfo(DiscordModelResolver resolver) => CreateJsonTypeInfo(resolver);

    static void ISTJModel<Discord.Models.Json.ActivityAssets>.Serialize(
        Utf8JsonWriter writer,
        Discord.Models.Json.ActivityAssets? model,
        DiscordModelResolver resolver
    ) => Serialize(writer, model, resolver);
}
