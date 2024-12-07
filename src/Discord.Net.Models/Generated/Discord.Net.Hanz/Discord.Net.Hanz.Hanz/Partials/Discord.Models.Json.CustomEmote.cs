using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed class PartialCustomEmote : Discord.Models.Json.PartialEmote, IPartial<Discord.Models.Json.CustomEmote>, Discord.Models.IPartialCustomEmoteModel, Discord.Models.IPartialEmoteModel, Discord.Models.IEntityModel<Discord.DiscordEmojiId>, Discord.Models.IEntityModel<ulong>, Discord.Models.IModel, Discord.Models.IModelSourceOf<Discord.Models.IUserModel?>
{
    [JsonPropertyName("id"), PartialIgnore]
    public ulong Id { get; set; }

    [JsonPropertyName("roles")]
    public Discord.Optional<ulong[]> RoleIds { get; set; }

    [JsonPropertyName("user")]
    public Discord.Optional<Discord.Models.Json.User> User { get; set; }

    [JsonPropertyName("require_colons")]
    public Discord.Optional<bool> RequireColons { get; set; }

    [JsonPropertyName("managed")]
    public Discord.Optional<bool> Managed { get; set; }

    [JsonPropertyName("animated")]
    public Discord.Optional<bool> Animated { get; set; }

    [JsonPropertyName("available")]
    public Discord.Optional<bool> Available { get; set; }

    [JsonIgnore]
    protected override DiscordEmojiId DiscordEmojiId => new(~Name, Id, ~Animated);

    public bool ApplyTo(Discord.Models.Json.CustomEmote model)
    {
        var result = base.ApplyTo(model);
        if (RoleIds.IsSpecified)
        {
            result |= true;
            model.RoleIds = RoleIds.Value;
        }

        if (User.IsSpecified)
        {
            result |= true;
            model.User = User.Value;
        }

        if (RequireColons.IsSpecified)
        {
            result |= true;
            model.RequireColons = RequireColons.Value;
        }

        if (Managed.IsSpecified)
        {
            result |= true;
            model.Managed = Managed.Value;
        }

        if (Animated.IsSpecified)
        {
            result |= true;
            model.Animated = Animated.Value;
        }

        if (Available.IsSpecified)
        {
            result |= true;
            model.Available = Available.Value;
        }

        return result;
    }

    public override Type UnderlyingModelType => typeof(Discord.Models.Json.CustomEmote);

    public override bool Has(string property)
    {
        return property switch
        {
            "Id" => true,
            "RoleIds" => RoleIds.IsSpecified,
            "User" => User.IsSpecified,
            "RequireColons" => RequireColons.IsSpecified,
            "Managed" => Managed.IsSpecified,
            "Animated" => Animated.IsSpecified,
            "Available" => Available.IsSpecified,
            _ => base.Has(property)};
    }

    public override bool TryGet<T>(string property, out T result)
    {
        return property switch
        {
            "Id" when Id is T val => (result = val) is T,
            "RoleIds" when RoleIds is { IsSpecified: true, Value: T val } => (result = val) is T,
            "User" when User is { IsSpecified: true, Value: T val } => (result = val) is T,
            "RequireColons" when RequireColons is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Managed" when Managed is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Animated" when Animated is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Available" when Available is { IsSpecified: true, Value: T val } => (result = val) is T,
            _ => base.TryGet<T>(property, out result)};
    }

    ulong[]? Discord.Models.IPartialCustomEmoteModel.Roles => RoleIds | [];

    bool Discord.Models.IPartialCustomEmoteModel.RolesIsSpecified => RoleIds.IsSpecified;

    bool? Discord.Models.IPartialCustomEmoteModel.RequireColons => RequireColons.ToNullable();

    bool Discord.Models.IPartialCustomEmoteModel.RequireColonsIsSpecified => RequireColons.IsSpecified;

    bool? Discord.Models.IPartialCustomEmoteModel.IsManaged => Managed.ToNullable();

    bool Discord.Models.IPartialCustomEmoteModel.IsManagedIsSpecified => Managed.IsSpecified;

    bool? Discord.Models.IPartialCustomEmoteModel.IsAnimated => Animated.ToNullable();

    bool Discord.Models.IPartialCustomEmoteModel.IsAnimatedIsSpecified => Animated.IsSpecified;

    bool? Discord.Models.IPartialCustomEmoteModel.IsAvailable => Available.ToNullable();

    bool Discord.Models.IPartialCustomEmoteModel.IsAvailableIsSpecified => Available.IsSpecified;

    ulong? Discord.Models.IPartialCustomEmoteModel.UserId => User.Map(v => v.Id).ToNullable();

    bool Discord.Models.IPartialCustomEmoteModel.UserIdIsSpecified => User.IsSpecified;

    bool Discord.Models.IPartial<Discord.Models.ICustomEmoteModel>.ApplyTo(Discord.Models.ICustomEmoteModel model) => model is Discord.Models.Json.CustomEmote ourModel && ApplyTo(ourModel);
    bool Discord.Models.IPartial<Discord.Models.IEmoteModel>.ApplyTo(Discord.Models.IEmoteModel model) => model is Discord.Models.Json.CustomEmote ourModel && ApplyTo(ourModel);
    public IEnumerable<IModel> GetDefinedModels()
    {
        if (User.IsSpecified)
            yield return User.Value;
    }

    Discord.Models.IUserModel? Discord.Models.IModelSourceOf<Discord.Models.IUserModel?>.Model => ~User;
}