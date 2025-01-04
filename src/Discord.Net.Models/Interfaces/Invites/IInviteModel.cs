namespace Discord.Models;

[ModelEquality]
public partial interface IInviteModel : IEntityModel<string>
{
    int Type { get; }
    string Code { get; }
    Optional<ModelOrId<IPartialGuildModel, ulong>> Guild { get; }
    ModelOrId<IPartialChannelModel, ulong>? ChannelId { get; }
    Optional<ModelOrId<IUserModel, ulong>> Inviter { get; }
    Optional<int> TargetType { get; }
    Optional<ModelOrId<IUserModel, ulong>> TargetUser { get; }
    Optional<ModelOrId<IPartialApplicationModel, ulong>> TargetApplication { get; }
    Optional<int> ApproximatePresenceCount { get; }
    Optional<int> ApproximateMemberCount { get; }
    Optional<DateTimeOffset?> ExpiresAt { get; }
    
    Optional<ModelOrId<IGuildScheduledEventModel, ulong>> GuildScheduledEvent { get; }

    string IEntityModel<string>.Id => Code;
}
