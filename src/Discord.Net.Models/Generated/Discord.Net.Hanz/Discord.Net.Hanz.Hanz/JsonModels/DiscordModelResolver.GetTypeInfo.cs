using System.Text.Json.Serialization.Metadata;
using System.Text.Json.Serialization;
using System.Text.Json;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class DiscordModelResolver : 
    IJsonTypeInfoResolver
{
    public override JsonTypeInfo? GetTypeInfo(Type type)
    {
        Options.TryGetTypeInfo(type, out var typeInfo);
        return typeInfo;
    }
    

    JsonTypeInfo? IJsonTypeInfoResolver.GetTypeInfo(Type type, JsonSerializerOptions options)
    {
        // interface -> model
        if(InterfaceModelMap.TryGetValue(type, out var modelType))
            return GetTypeInfo(modelType);
            
        // primitives (9)
        if(type == typeof(System.DateTimeOffset))
           return Create_DateTimeOffset(options);
        if(type == typeof(string))
           return Create_String(options);
        if(type == typeof(System.Collections.Generic.IReadOnlyCollection<int>))
           return Create_IReadOnlyCollectionInt32(options);
        if(type == typeof(int))
           return Create_Int32(options);
        if(type == typeof(string?))
           return Create_String(options);
        if(type == typeof(ulong))
           return Create_UInt64(options);
        if(type == typeof(Discord.DiscordEmojiId?))
           return Create_NullableDiscordEmojiId(options);
        if(type == typeof(bool))
           return Create_Boolean(options);
        if(type == typeof(System.Collections.Generic.IReadOnlyCollection<Discord.Models.Json.ActivityButton>))
           return Create_IReadOnlyCollectionActivityButton(options);
        
        // models (6)
        if(type == typeof(Discord.Models.Json.ActivityTimestamps))
            return Discord.Models.Json.ActivityTimestamps.CreateJsonTypeInfo(this);
        if(type == typeof(Discord.Models.Json.ActivitySecrets))
            return Discord.Models.Json.ActivitySecrets.CreateJsonTypeInfo(this);
        if(type == typeof(Discord.Models.Json.ActivityParty))
            return Discord.Models.Json.ActivityParty.CreateJsonTypeInfo(this);
        if(type == typeof(Discord.Models.Json.ActivityButton))
            return Discord.Models.Json.ActivityButton.CreateJsonTypeInfo(this);
        if(type == typeof(Discord.Models.Json.ActivityAssets))
            return Discord.Models.Json.ActivityAssets.CreateJsonTypeInfo(this);
        if(type == typeof(Discord.Models.Json.Activity))
            return Discord.Models.Json.Activity.CreateJsonTypeInfo(this);
        
        return null;
    }
    
}
