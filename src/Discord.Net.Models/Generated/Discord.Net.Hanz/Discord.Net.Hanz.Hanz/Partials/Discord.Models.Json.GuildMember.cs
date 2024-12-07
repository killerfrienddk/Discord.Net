using Discord.Models;
using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed class PartialGuildMember : IPartial<Discord.Models.Json.GuildMember>, Discord.Models.IPartialMemberModel, Discord.Models.IEntityModel<ulong>, Discord.Models.IModel, Discord.Models.IModelSourceOf<Discord.Models.IUserModel?>
{
    [JsonPropertyName("user")]
    public Discord.Optional<Discord.Models.Json.User> User { get; set; }

    [JsonPropertyName("nick")]
    public Discord.Optional<string?> Nick { get; set; }

    [JsonPropertyName("avatar")]
    public Discord.Optional<string?> Avatar { get; set; }

    [JsonPropertyName("roles")]
    public Discord.Optional<ulong[]> RoleIds { get; set; }

    [JsonPropertyName("joined_at")]
    public Discord.Optional<System.DateTimeOffset> JoinedAt { get; set; }

    [JsonPropertyName("premium_since")]
    public Discord.Optional<System.DateTimeOffset?> PremiumSince { get; set; }

    [JsonPropertyName("deaf")]
    public Discord.Optional<bool> Deaf { get; set; }

    [JsonPropertyName("mute")]
    public Discord.Optional<bool> Mute { get; set; }

    [JsonPropertyName("flags")]
    public Discord.Optional<int> Flags { get; set; }

    [JsonPropertyName("pending")]
    public Discord.Optional<bool> Pending { get; set; }

    // Only returned with interaction object
    [JsonPropertyName("permissions")]
    public Discord.Optional<ulong> Permissions { get; set; }

    [JsonPropertyName("communication_disabled_until")]
    public Discord.Optional<System.DateTimeOffset?> CommunicationsDisabledUntil { get; set; }

    [JsonPropertyName("avatar_decoration_data")]
    public Discord.Optional<Discord.Models.Json.AvatarDecorationData?> AvatarDecoration { get; set; }

    public bool ApplyTo(Discord.Models.Json.GuildMember model)
    {
        var result = false;
        if (User.IsSpecified)
        {
            result |= true;
            model.User = User.Value;
        }

        if (Nick.IsSpecified)
        {
            result |= true;
            model.Nick = Nick.Value;
        }

        if (Avatar.IsSpecified)
        {
            result |= true;
            model.Avatar = Avatar.Value;
        }

        if (RoleIds.IsSpecified)
        {
            result |= true;
            model.RoleIds = RoleIds.Value;
        }

        if (JoinedAt.IsSpecified)
        {
            result |= true;
            model.JoinedAt = JoinedAt.Value;
        }

        if (PremiumSince.IsSpecified)
        {
            result |= true;
            model.PremiumSince = PremiumSince.Value;
        }

        if (Deaf.IsSpecified)
        {
            result |= true;
            model.Deaf = Deaf.Value;
        }

        if (Mute.IsSpecified)
        {
            result |= true;
            model.Mute = Mute.Value;
        }

        if (Flags.IsSpecified)
        {
            result |= true;
            model.Flags = Flags.Value;
        }

        if (Pending.IsSpecified)
        {
            result |= true;
            model.Pending = Pending.Value;
        }

        if (Permissions.IsSpecified)
        {
            result |= true;
            model.Permissions = Permissions.Value;
        }

        if (CommunicationsDisabledUntil.IsSpecified)
        {
            result |= true;
            model.CommunicationsDisabledUntil = CommunicationsDisabledUntil.Value;
        }

        if (AvatarDecoration.IsSpecified)
        {
            result |= true;
            model.AvatarDecoration = AvatarDecoration.Value;
        }

        return result;
    }

    public Type UnderlyingModelType => typeof(Discord.Models.Json.GuildMember);

    public bool Has(string property)
    {
        return property switch
        {
            "User" => User.IsSpecified,
            "Nick" => Nick.IsSpecified,
            "Avatar" => Avatar.IsSpecified,
            "RoleIds" => RoleIds.IsSpecified,
            "JoinedAt" => JoinedAt.IsSpecified,
            "PremiumSince" => PremiumSince.IsSpecified,
            "Deaf" => Deaf.IsSpecified,
            "Mute" => Mute.IsSpecified,
            "Flags" => Flags.IsSpecified,
            "Pending" => Pending.IsSpecified,
            "Permissions" => Permissions.IsSpecified,
            "CommunicationsDisabledUntil" => CommunicationsDisabledUntil.IsSpecified,
            "AvatarDecoration" => AvatarDecoration.IsSpecified,
            _ => false
        };
    }

    public bool TryGet<T>(string property, out T result)
    {
        return property switch
        {
            "User" when User is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Nick" when Nick is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Avatar" when Avatar is { IsSpecified: true, Value: T val } => (result = val) is T,
            "RoleIds" when RoleIds is { IsSpecified: true, Value: T val } => (result = val) is T,
            "JoinedAt" when JoinedAt is { IsSpecified: true, Value: T val } => (result = val) is T,
            "PremiumSince" when PremiumSince is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Deaf" when Deaf is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Mute" when Mute is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Flags" when Flags is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Pending" when Pending is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Permissions" when Permissions is { IsSpecified: true, Value: T val } => (result = val) is T,
            "CommunicationsDisabledUntil" when CommunicationsDisabledUntil is { IsSpecified: true, Value: T val } => (result = val) is T,
            "AvatarDecoration" when AvatarDecoration is { IsSpecified: true, Value: T val } => (result = val) is T,
            _ => (result = default(T)!)is not T
        };
    }

    int? Discord.Models.IPartialMemberModel.Flags => Flags.ToNullable();

    bool Discord.Models.IPartialMemberModel.FlagsIsSpecified => Flags.IsSpecified;

    string? Discord.Models.IPartialMemberModel.Nickname => ~Nick;

    bool Discord.Models.IPartialMemberModel.NicknameIsSpecified => Nick.IsSpecified;

    string? Discord.Models.IPartialMemberModel.Avatar => ~Avatar;

    bool Discord.Models.IPartialMemberModel.AvatarIsSpecified => Avatar.IsSpecified;

    ulong[]? Discord.Models.IPartialMemberModel.RoleIds => ~RoleIds;

    bool Discord.Models.IPartialMemberModel.RoleIdsIsSpecified => RoleIds.IsSpecified;

    System.DateTimeOffset? Discord.Models.IPartialMemberModel.JoinedAt => ~JoinedAt;

    bool Discord.Models.IPartialMemberModel.JoinedAtIsSpecified => JoinedAt.IsSpecified;

    System.DateTimeOffset? Discord.Models.IPartialMemberModel.PremiumSince => ~PremiumSince;

    bool Discord.Models.IPartialMemberModel.PremiumSinceIsSpecified => PremiumSince.IsSpecified;

    bool? Discord.Models.IPartialMemberModel.IsPending => Pending.ToNullable();

    bool Discord.Models.IPartialMemberModel.IsPendingIsSpecified => Pending.IsSpecified;

    System.DateTimeOffset? Discord.Models.IPartialMemberModel.CommunicationsDisabledUntil => ~CommunicationsDisabledUntil;

    bool Discord.Models.IPartialMemberModel.CommunicationsDisabledUntilIsSpecified => CommunicationsDisabledUntil.IsSpecified;

    Discord.Models.IAvatarDecorationDataModel? Discord.Models.IPartialMemberModel.AvatarDecoration => ~AvatarDecoration;

    bool Discord.Models.IPartialMemberModel.AvatarDecorationIsSpecified => AvatarDecoration.IsSpecified;

    bool Discord.Models.IPartial<Discord.Models.IMemberModel>.ApplyTo(Discord.Models.IMemberModel model) => model is Discord.Models.Json.GuildMember ourModel && ApplyTo(ourModel);
    ulong Discord.Models.IEntityModel<ulong>.Id => ~User.Map(v => v.Id);

    public IEnumerable<IModel> GetDefinedModels()
    {
        if (User.IsSpecified)
            yield return User.Value;
    }

    Discord.Models.IUserModel? Discord.Models.IModelSourceOf<Discord.Models.IUserModel?>.Model => ~User;
}