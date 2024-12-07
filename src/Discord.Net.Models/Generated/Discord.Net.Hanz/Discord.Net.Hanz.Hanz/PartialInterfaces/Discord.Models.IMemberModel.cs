

namespace Discord.Models;

public partial interface IPartialMemberModel : Discord.Models.IPartial<Discord.Models.IMemberModel>, Discord.Models.IEntityModel<ulong>
{
    int? Flags { get; }

    bool FlagsIsSpecified { get; }

    string? Nickname { get; }

    bool NicknameIsSpecified { get; }

    string? Avatar { get; }

    bool AvatarIsSpecified { get; }

    ulong[]? RoleIds { get; }

    bool RoleIdsIsSpecified { get; }

    System.DateTimeOffset? JoinedAt { get; }

    bool JoinedAtIsSpecified { get; }

    System.DateTimeOffset? PremiumSince { get; }

    bool PremiumSinceIsSpecified { get; }

    bool? IsPending { get; }

    bool IsPendingIsSpecified { get; }

    System.DateTimeOffset? CommunicationsDisabledUntil { get; }

    bool CommunicationsDisabledUntilIsSpecified { get; }

    Discord.Models.IAvatarDecorationDataModel? AvatarDecoration { get; }

    bool AvatarDecorationIsSpecified { get; }
}