namespace Discord.Models;

public interface IGuildMemberUpdatedPayloadData : IGatewayPayloadData
{
    ulong GuildId { get; }
    IReadOnlyCollection<ulong> Roles { get; }
    IUserModel User { get; }
    Optional<string?> Nickname { get; }
    string? Avatar { get; }
    DateTimeOffset? JoinedAt { get; }
    DateTimeOffset? PremiumSince { get; }
    Optional<bool> IsDeaf { get; }
    Optional<bool> IsMute { get; }
    Optional<bool> IsPending { get; }
    Optional<DateTimeOffset?> CommunicationsDisabledUntil { get; }
    Optional<int> Flags { get; }
    Optional<IAvatarDecorationDataModel?> AvatarDecoration { get; }
}
