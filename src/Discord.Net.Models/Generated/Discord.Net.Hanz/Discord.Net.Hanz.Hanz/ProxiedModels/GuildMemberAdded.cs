using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class GuildMemberAdded : IExtendedModel<Discord.Models.Json.GuildMember>
{
    Discord.Models.Json.GuildMember IExtendedModel<Discord.Models.Json.GuildMember>.ExtendedValue => Member;

    int Discord.Models.IMemberModel.Flags => (Member as Discord.Models.IMemberModel).Flags;

    string? Discord.Models.IMemberModel.Nickname => (Member as Discord.Models.IMemberModel).Nickname;

    string? Discord.Models.IMemberModel.Avatar => (Member as Discord.Models.IMemberModel).Avatar;

    ulong[] Discord.Models.IMemberModel.RoleIds => (Member as Discord.Models.IMemberModel).RoleIds;

    System.DateTimeOffset? Discord.Models.IMemberModel.JoinedAt => (Member as Discord.Models.IMemberModel).JoinedAt;

    System.DateTimeOffset? Discord.Models.IMemberModel.PremiumSince => (Member as Discord.Models.IMemberModel).PremiumSince;

    bool? Discord.Models.IMemberModel.IsPending => (Member as Discord.Models.IMemberModel).IsPending;

    System.DateTimeOffset? Discord.Models.IMemberModel.CommunicationsDisabledUntil => (Member as Discord.Models.IMemberModel).CommunicationsDisabledUntil;

    Discord.Models.IAvatarDecorationDataModel? Discord.Models.IMemberModel.AvatarDecoration => (Member as Discord.Models.IMemberModel).AvatarDecoration;

    ulong Discord.Models.IEntityModel<ulong>.Id => (Member as Discord.Models.IEntityModel<ulong>).Id;
}