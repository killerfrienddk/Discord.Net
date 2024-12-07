using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public abstract class PartialEmote : IPartial<Discord.Models.Json.Emote>, Discord.Models.IPartialEmoteModel, Discord.Models.IEntityModel<Discord.DiscordEmojiId>, Discord.Models.IModel
{
    [JsonPropertyName("name"), NullableInPartial]
    public Discord.Optional<string?> Name { get; set; }
    protected abstract Discord.DiscordEmojiId DiscordEmojiId { get; }

    public bool ApplyTo(Discord.Models.Json.Emote model)
    {
        var result = false;
        if (Name.IsSpecified && Name.Value is not null)
        {
            result |= true;
            model.Name = Name.Value;
        }

        return result;
    }

    public virtual Type UnderlyingModelType => typeof(Discord.Models.Json.Emote);

    public virtual bool Has(string property)
    {
        return property switch
        {
            "Name" => Name.IsSpecified,
            _ => false
        };
    }

    public virtual bool TryGet<T>(string property, out T result)
    {
        return property switch
        {
            "Name" when Name is { IsSpecified: true, Value: T val } => (result = val) is T,
            _ => (result = default(T)!)is not T
        };
    }

    string? Discord.Models.IPartialEmoteModel.Name => ~Name;

    bool Discord.Models.IPartialEmoteModel.NameIsSpecified => Name.IsSpecified;

    bool Discord.Models.IPartial<Discord.Models.IEmoteModel>.ApplyTo(Discord.Models.IEmoteModel model) => model is Discord.Models.Json.Emote ourModel && ApplyTo(ourModel);
    Discord.DiscordEmojiId Discord.Models.IEntityModel<Discord.DiscordEmojiId>.Id => DiscordEmojiId;
}