using Discord.Converters;
using Discord.Models;
using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public class PartialUser : IPartial<Discord.Models.Json.User>, Discord.Models.IPartialUserModel, Discord.Models.IEntityModel<ulong>, Discord.Models.IModel
{
    [JsonPropertyName("id"), JsonRequired]
    public ulong Id { get; set; }

    [JsonPropertyName("username")]
    public Discord.Optional<string> Username { get; set; }

    [JsonPropertyName("discriminator")]
    public Discord.Optional<string> Discriminator { get; set; }

    [JsonPropertyName("global_name")]
    public Discord.Optional<string?> GlobalName { get; set; }

    [JsonPropertyName("avatar")]
    public Discord.Optional<string?> Avatar { get; set; }

    [JsonPropertyName("bot")]
    public Discord.Optional<bool> IsBot { get; set; }

    [JsonPropertyName("system")]
    public Discord.Optional<bool> IsSystem { get; set; }

    [JsonPropertyName("banner")]
    public Discord.Optional<string?> Banner { get; set; }

    [JsonPropertyName("accent_color")]
    public Discord.Optional<int?> AccentColor { get; set; }

    [JsonPropertyName("flags")]
    public Discord.Optional<int> Flags { get; set; }

    [JsonPropertyName("public_flags")]
    public Discord.Optional<int> PublicFlags { get; set; }

    [JsonPropertyName("avatar_decoration_data")]
    public Discord.Optional<Discord.Models.Json.AvatarDecorationData?> AvatarDecoration { get; set; }

    public bool ApplyTo(Discord.Models.Json.User model)
    {
        var result = false;
        if (Username.IsSpecified)
        {
            result |= true;
            model.Username = Username.Value;
        }

        if (Discriminator.IsSpecified)
        {
            result |= true;
            model.Discriminator = Discriminator.Value;
        }

        if (GlobalName.IsSpecified)
        {
            result |= true;
            model.GlobalName = GlobalName.Value;
        }

        if (Avatar.IsSpecified)
        {
            result |= true;
            model.Avatar = Avatar.Value;
        }

        if (IsBot.IsSpecified)
        {
            result |= true;
            model.IsBot = IsBot.Value;
        }

        if (IsSystem.IsSpecified)
        {
            result |= true;
            model.IsSystem = IsSystem.Value;
        }

        if (Banner.IsSpecified)
        {
            result |= true;
            model.Banner = Banner.Value;
        }

        if (AccentColor.IsSpecified)
        {
            result |= true;
            model.AccentColor = AccentColor.Value;
        }

        if (Flags.IsSpecified)
        {
            result |= true;
            model.Flags = Flags.Value;
        }

        if (PublicFlags.IsSpecified)
        {
            result |= true;
            model.PublicFlags = PublicFlags.Value;
        }

        if (AvatarDecoration.IsSpecified)
        {
            result |= true;
            model.AvatarDecoration = AvatarDecoration.Value;
        }

        return result;
    }

    public Type UnderlyingModelType => typeof(Discord.Models.Json.User);

    public bool Has(string property)
    {
        return property switch
        {
            "Id" => true,
            "Username" => Username.IsSpecified,
            "Discriminator" => Discriminator.IsSpecified,
            "GlobalName" => GlobalName.IsSpecified,
            "Avatar" => Avatar.IsSpecified,
            "IsBot" => IsBot.IsSpecified,
            "IsSystem" => IsSystem.IsSpecified,
            "Banner" => Banner.IsSpecified,
            "AccentColor" => AccentColor.IsSpecified,
            "Flags" => Flags.IsSpecified,
            "PublicFlags" => PublicFlags.IsSpecified,
            "AvatarDecoration" => AvatarDecoration.IsSpecified,
            _ => false
        };
    }

    public bool TryGet<T>(string property, out T result)
    {
        return property switch
        {
            "Id" when Id is T val => (result = val) is T,
            "Username" when Username is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Discriminator" when Discriminator is { IsSpecified: true, Value: T val } => (result = val) is T,
            "GlobalName" when GlobalName is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Avatar" when Avatar is { IsSpecified: true, Value: T val } => (result = val) is T,
            "IsBot" when IsBot is { IsSpecified: true, Value: T val } => (result = val) is T,
            "IsSystem" when IsSystem is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Banner" when Banner is { IsSpecified: true, Value: T val } => (result = val) is T,
            "AccentColor" when AccentColor is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Flags" when Flags is { IsSpecified: true, Value: T val } => (result = val) is T,
            "PublicFlags" when PublicFlags is { IsSpecified: true, Value: T val } => (result = val) is T,
            "AvatarDecoration" when AvatarDecoration is { IsSpecified: true, Value: T val } => (result = val) is T,
            _ => (result = default(T)!)is not T
        };
    }

    string? Discord.Models.IPartialUserModel.Username => ~Username;

    bool Discord.Models.IPartialUserModel.UsernameIsSpecified => Username.IsSpecified;

    string? Discord.Models.IPartialUserModel.Discriminator => ~Discriminator;

    bool Discord.Models.IPartialUserModel.DiscriminatorIsSpecified => Discriminator.IsSpecified;

    string? Discord.Models.IPartialUserModel.GlobalName => ~GlobalName;

    bool Discord.Models.IPartialUserModel.GlobalNameIsSpecified => GlobalName.IsSpecified;

    string? Discord.Models.IPartialUserModel.Avatar => ~Avatar;

    bool Discord.Models.IPartialUserModel.AvatarIsSpecified => Avatar.IsSpecified;

    bool? Discord.Models.IPartialUserModel.IsBot => ~IsBot;

    bool Discord.Models.IPartialUserModel.IsBotIsSpecified => IsBot.IsSpecified;

    bool? Discord.Models.IPartialUserModel.IsSystem => ~IsSystem;

    bool Discord.Models.IPartialUserModel.IsSystemIsSpecified => IsSystem.IsSpecified;

    int? Discord.Models.IPartialUserModel.Flags => ~Flags;

    bool Discord.Models.IPartialUserModel.FlagsIsSpecified => Flags.IsSpecified;

    int? Discord.Models.IPartialUserModel.PublicFlags => ~PublicFlags;

    bool Discord.Models.IPartialUserModel.PublicFlagsIsSpecified => PublicFlags.IsSpecified;

    Discord.Models.IAvatarDecorationDataModel? Discord.Models.IPartialUserModel.AvatarDecoration => ~AvatarDecoration;

    bool Discord.Models.IPartialUserModel.AvatarDecorationIsSpecified => AvatarDecoration.IsSpecified;

    bool Discord.Models.IPartial<Discord.Models.IUserModel>.ApplyTo(Discord.Models.IUserModel model) => model is Discord.Models.Json.User ourModel && ApplyTo(ourModel);
}