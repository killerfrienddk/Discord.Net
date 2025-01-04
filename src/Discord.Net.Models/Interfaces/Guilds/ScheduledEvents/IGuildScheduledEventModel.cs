namespace Discord.Models;

[ModelEquality]
public partial interface IGuildScheduledEventModel : IEntityModel<ulong>
{
    ulong GuildId { get; }
    Optional<ulong?> ChannelId { get; }
    ModelOrId<IUserModel, ulong> Creator { get; }
    string Name { get; }
    Optional<string?> Description { get; }
    DateTimeOffset ScheduledStartTime { get; }
    DateTimeOffset? ScheduledEndTime { get; }
    int PrivacyLevel { get; }
    int Status { get; }
    int EntityType { get; }
    ulong? EntityId { get; }
    IGuildScheduledEventMetadataModel? EntityMetadata { get; }
    Optional<int> UserCount { get; }
    Optional<string?> Image { get; }
    IGuildScheduledEventRecurrenceRuleModel? RecurrenceRule { get; }
}