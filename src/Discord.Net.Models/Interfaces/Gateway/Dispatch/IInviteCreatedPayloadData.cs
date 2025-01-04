namespace Discord.Models;

public interface IInviteCreatedPayloadData : IGatewayPayloadData
{
    ulong ChannelId { get; }
    string Code { get; }
    DateTimeOffset CreatedAt { get; }
    Optional<ulong> GuildId { get; }
    Optional<IUserModel> Inviter { get; }
    int MaxAge { get; }
    int MaxUses { get; }
    Optional<int> TargetType { get; }
    Optional<IUserModel> TargetUser { get; }
    Optional<IPartialApplicationModel> TargetApplication { get; }
    bool IsTemporary { get; }
    int Uses { get; }
}
