using System.Text.Json.Serialization.Metadata;
using System.Text.Json.Serialization;
using System.Text.Json;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial record Activity : 
    ISTJModel<Discord.Models.Json.Activity>
{
    private static readonly JsonEncodedText __JsonPropNameName = JsonEncodedText.Encode("name");
    private static readonly JsonEncodedText __JsonPropNameType = JsonEncodedText.Encode("type");
    private static readonly JsonEncodedText __JsonPropNameUrl = JsonEncodedText.Encode("url");
    private static readonly JsonEncodedText __JsonPropNameCreatedAt = JsonEncodedText.Encode("created_at");
    private static readonly JsonEncodedText __JsonPropNameTimestamps = JsonEncodedText.Encode("timestamps");
    private static readonly JsonEncodedText __JsonPropNameApplicationId = JsonEncodedText.Encode("application_id");
    private static readonly JsonEncodedText __JsonPropNameDetails = JsonEncodedText.Encode("details");
    private static readonly JsonEncodedText __JsonPropNameState = JsonEncodedText.Encode("state");
    private static readonly JsonEncodedText __JsonPropNameEmoji = JsonEncodedText.Encode("emoji");
    private static readonly JsonEncodedText __JsonPropNameParty = JsonEncodedText.Encode("party");
    private static readonly JsonEncodedText __JsonPropNameAssets = JsonEncodedText.Encode("assets");
    private static readonly JsonEncodedText __JsonPropNameSecrets = JsonEncodedText.Encode("secrets");
    private static readonly JsonEncodedText __JsonPropNameIsInstance = JsonEncodedText.Encode("instance");
    private static readonly JsonEncodedText __JsonPropNameFlags = JsonEncodedText.Encode("flags");
    private static readonly JsonEncodedText __JsonPropNameButtons = JsonEncodedText.Encode("buttons");


    internal static JsonTypeInfo<Discord.Models.Json.Activity> CreateJsonTypeInfo(DiscordModelResolver resolver) => JsonMetadataServices.CreateObjectInfo<Discord.Models.Json.Activity>(resolver.Options, new JsonObjectInfoValues<Discord.Models.Json.Activity>
    {
        ObjectCreator = null,
        ObjectWithParameterizedConstructorCreator = static args => new Discord.Models.Json.Activity((string)args[0], (int)args[1], (Discord.Optional<string?>)args[2], (System.DateTimeOffset)args[3], (Discord.Optional<Discord.Models.Json.ActivityTimestamps>)args[4], (Discord.Optional<ulong>)args[5], (Discord.Optional<string?>)args[6], (Discord.Optional<string?>)args[7], (Discord.Optional<Discord.DiscordEmojiId?>)args[8], (Discord.Optional<Discord.Models.Json.ActivityParty>)args[9], (Discord.Optional<Discord.Models.Json.ActivityAssets>)args[10], (Discord.Optional<Discord.Models.Json.ActivitySecrets>)args[11], (Discord.Optional<bool>)args[12], (Discord.Optional<int>)args[13], (Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.Json.ActivityButton>>)args[14]),
        PropertyMetadataInitializer = _ => Discord.Models.Json.Activity.GetPropertyInfos(resolver.Options),
        ConstructorParameterMetadataInitializer = Discord.Models.Json.Activity.GetCtorParamsInfo,
        SerializeHandler = (writer, model) => Discord.Models.Json.Activity.Serialize(writer, model, resolver)
    });

    internal static void Serialize(
        Utf8JsonWriter writer,
        Discord.Models.Json.Activity? model,
        DiscordModelResolver resolver
    )
    {
        if(model is null)
        {
            writer.WriteNullValue();
            return;
        }
        
        writer.WriteStartObject();
        
        // "Name" of type "string"
        writer.WriteString(__JsonPropNameName, model.Name);
        
        // "Type" of type "int"
        writer.WriteNumber(__JsonPropNameType, model.Type);
        
        // "Url" of type "Discord.Optional<string?>"
        if(model.Url.IsSpecified)
        {
            writer.WriteString(__JsonPropNameUrl, model.Url.Value);
        }
        
        // "CreatedAt" of type "System.DateTimeOffset"
        writer.WritePropertyName(__JsonPropNameCreatedAt);
        JsonSerializer.Serialize(writer, model.CreatedAt, resolver.Options);
        
        // "Timestamps" of type "Discord.Optional<Discord.Models.Json.ActivityTimestamps>"
        if(model.Timestamps.IsSpecified)
        {
            writer.WritePropertyName(__JsonPropNameTimestamps);
            JsonSerializer.Serialize(writer, model.Timestamps.Value, resolver.ActivityTimestampsJsonTypeInfo);
        }
        
        // "ApplicationId" of type "Discord.Optional<ulong>"
        if(model.ApplicationId.IsSpecified)
        {
            writer.WriteNumber(__JsonPropNameApplicationId, model.ApplicationId.Value);
        }
        
        // "Details" of type "Discord.Optional<string?>"
        if(model.Details.IsSpecified)
        {
            writer.WriteString(__JsonPropNameDetails, model.Details.Value);
        }
        
        // "State" of type "Discord.Optional<string?>"
        if(model.State.IsSpecified)
        {
            writer.WriteString(__JsonPropNameState, model.State.Value);
        }
        
        // "Emoji" of type "Discord.Optional<Discord.DiscordEmojiId?>"
        if(model.Emoji.IsSpecified)
        {
            writer.WritePropertyName(__JsonPropNameEmoji);
            JsonSerializer.Serialize(writer, model.Emoji.Value, resolver.Options);
        }
        
        // "Party" of type "Discord.Optional<Discord.Models.Json.ActivityParty>"
        if(model.Party.IsSpecified)
        {
            writer.WritePropertyName(__JsonPropNameParty);
            JsonSerializer.Serialize(writer, model.Party.Value, resolver.ActivityPartyJsonTypeInfo);
        }
        
        // "Assets" of type "Discord.Optional<Discord.Models.Json.ActivityAssets>"
        if(model.Assets.IsSpecified)
        {
            writer.WritePropertyName(__JsonPropNameAssets);
            JsonSerializer.Serialize(writer, model.Assets.Value, resolver.ActivityAssetsJsonTypeInfo);
        }
        
        // "Secrets" of type "Discord.Optional<Discord.Models.Json.ActivitySecrets>"
        if(model.Secrets.IsSpecified)
        {
            writer.WritePropertyName(__JsonPropNameSecrets);
            JsonSerializer.Serialize(writer, model.Secrets.Value, resolver.ActivitySecretsJsonTypeInfo);
        }
        
        // "IsInstance" of type "Discord.Optional<bool>"
        if(model.IsInstance.IsSpecified)
        {
            writer.WriteBoolean(__JsonPropNameIsInstance, model.IsInstance.Value);
        }
        
        // "Flags" of type "Discord.Optional<int>"
        if(model.Flags.IsSpecified)
        {
            writer.WriteNumber(__JsonPropNameFlags, model.Flags.Value);
        }
        
        // "Buttons" of type "Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.Json.ActivityButton>>"
        if(model.Buttons.IsSpecified)
        {
            writer.WritePropertyName(__JsonPropNameButtons);
            JsonSerializer.Serialize(writer, model.Buttons.Value, resolver.Options);
        }
        
        writer.WriteEndObject();
    }
    

    internal static JsonPropertyInfo[] GetPropertyInfos(JsonSerializerOptions options)
    {
        var props = new JsonPropertyInfo[15];
        props[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).Name,
            Setter = null,
            PropertyName = "Name",
            JsonPropertyName = "name",
            IgnoreCondition = null
        });
        props[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).Type,
            Setter = null,
            PropertyName = "Type",
            JsonPropertyName = "type",
            IgnoreCondition = null
        });
        props[2] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<string?>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).Url,
            Setter = null,
            PropertyName = "Url",
            JsonPropertyName = "url",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[3] = JsonMetadataServices.CreatePropertyInfo<System.DateTimeOffset>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).CreatedAt,
            Setter = null,
            PropertyName = "CreatedAt",
            JsonPropertyName = "created_at",
            IgnoreCondition = null
        });
        props[4] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<Discord.Models.Json.ActivityTimestamps>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).Timestamps,
            Setter = null,
            PropertyName = "Timestamps",
            JsonPropertyName = "timestamps",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[5] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<ulong>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).ApplicationId,
            Setter = null,
            PropertyName = "ApplicationId",
            JsonPropertyName = "application_id",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[6] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<string?>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).Details,
            Setter = null,
            PropertyName = "Details",
            JsonPropertyName = "details",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[7] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<string?>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).State,
            Setter = null,
            PropertyName = "State",
            JsonPropertyName = "state",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[8] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<Discord.DiscordEmojiId?>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).Emoji,
            Setter = null,
            PropertyName = "Emoji",
            JsonPropertyName = "emoji",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[9] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<Discord.Models.Json.ActivityParty>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).Party,
            Setter = null,
            PropertyName = "Party",
            JsonPropertyName = "party",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[10] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<Discord.Models.Json.ActivityAssets>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).Assets,
            Setter = null,
            PropertyName = "Assets",
            JsonPropertyName = "assets",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[11] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<Discord.Models.Json.ActivitySecrets>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).Secrets,
            Setter = null,
            PropertyName = "Secrets",
            JsonPropertyName = "secrets",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[12] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<bool>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).IsInstance,
            Setter = null,
            PropertyName = "IsInstance",
            JsonPropertyName = "instance",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[13] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<int>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).Flags,
            Setter = null,
            PropertyName = "Flags",
            JsonPropertyName = "flags",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        props[14] = JsonMetadataServices.CreatePropertyInfo<Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.Json.ActivityButton>>>(options, new()
        {
            IsProperty = true,
            IsPublic = true,
            DeclaringType = typeof(Discord.Models.Json.Activity),
            Getter = static obj => ((Discord.Models.Json.Activity)obj).Buttons,
            Setter = null,
            PropertyName = "Buttons",
            JsonPropertyName = "buttons",
            IgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        });
        return props;
    }
    

    static JsonTypeInfo<Discord.Models.Json.Activity> ISTJModel<Discord.Models.Json.Activity>.CreateJsonTypeInfo(DiscordModelResolver resolver) => CreateJsonTypeInfo(resolver);

    static void ISTJModel<Discord.Models.Json.Activity>.Serialize(
        Utf8JsonWriter writer,
        Discord.Models.Json.Activity? model,
        DiscordModelResolver resolver
    ) => Serialize(writer, model, resolver);

    internal static JsonParameterInfoValues[] GetCtorParamsInfo()
    {
        var parameters = new JsonParameterInfoValues[15];
        
        parameters[0] = new()
        {
            Name = "Name",
            ParameterType = typeof(string),
            Position = 0,
            HasDefaultValue = false,
            DefaultValue = default(string)
        };
        parameters[1] = new()
        {
            Name = "Type",
            ParameterType = typeof(int),
            Position = 1,
            HasDefaultValue = false,
            DefaultValue = default(int)
        };
        parameters[2] = new()
        {
            Name = "Url",
            ParameterType = typeof(Discord.Optional<string?>),
            Position = 2,
            HasDefaultValue = false,
            DefaultValue = default(Discord.Optional<string?>)
        };
        parameters[3] = new()
        {
            Name = "CreatedAt",
            ParameterType = typeof(System.DateTimeOffset),
            Position = 3,
            HasDefaultValue = false,
            DefaultValue = default(System.DateTimeOffset)
        };
        parameters[4] = new()
        {
            Name = "Timestamps",
            ParameterType = typeof(Discord.Optional<Discord.Models.Json.ActivityTimestamps>),
            Position = 4,
            HasDefaultValue = false,
            DefaultValue = default(Discord.Optional<Discord.Models.Json.ActivityTimestamps>)
        };
        parameters[5] = new()
        {
            Name = "ApplicationId",
            ParameterType = typeof(Discord.Optional<ulong>),
            Position = 5,
            HasDefaultValue = false,
            DefaultValue = default(Discord.Optional<ulong>)
        };
        parameters[6] = new()
        {
            Name = "Details",
            ParameterType = typeof(Discord.Optional<string?>),
            Position = 6,
            HasDefaultValue = false,
            DefaultValue = default(Discord.Optional<string?>)
        };
        parameters[7] = new()
        {
            Name = "State",
            ParameterType = typeof(Discord.Optional<string?>),
            Position = 7,
            HasDefaultValue = false,
            DefaultValue = default(Discord.Optional<string?>)
        };
        parameters[8] = new()
        {
            Name = "Emoji",
            ParameterType = typeof(Discord.Optional<Discord.DiscordEmojiId?>),
            Position = 8,
            HasDefaultValue = false,
            DefaultValue = default(Discord.Optional<Discord.DiscordEmojiId?>)
        };
        parameters[9] = new()
        {
            Name = "Party",
            ParameterType = typeof(Discord.Optional<Discord.Models.Json.ActivityParty>),
            Position = 9,
            HasDefaultValue = false,
            DefaultValue = default(Discord.Optional<Discord.Models.Json.ActivityParty>)
        };
        parameters[10] = new()
        {
            Name = "Assets",
            ParameterType = typeof(Discord.Optional<Discord.Models.Json.ActivityAssets>),
            Position = 10,
            HasDefaultValue = false,
            DefaultValue = default(Discord.Optional<Discord.Models.Json.ActivityAssets>)
        };
        parameters[11] = new()
        {
            Name = "Secrets",
            ParameterType = typeof(Discord.Optional<Discord.Models.Json.ActivitySecrets>),
            Position = 11,
            HasDefaultValue = false,
            DefaultValue = default(Discord.Optional<Discord.Models.Json.ActivitySecrets>)
        };
        parameters[12] = new()
        {
            Name = "IsInstance",
            ParameterType = typeof(Discord.Optional<bool>),
            Position = 12,
            HasDefaultValue = false,
            DefaultValue = default(Discord.Optional<bool>)
        };
        parameters[13] = new()
        {
            Name = "Flags",
            ParameterType = typeof(Discord.Optional<int>),
            Position = 13,
            HasDefaultValue = false,
            DefaultValue = default(Discord.Optional<int>)
        };
        parameters[14] = new()
        {
            Name = "Buttons",
            ParameterType = typeof(Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.Json.ActivityButton>>),
            Position = 14,
            HasDefaultValue = false,
            DefaultValue = default(Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.Json.ActivityButton>>)
        };
        
        
        return parameters;
    }
    
}
