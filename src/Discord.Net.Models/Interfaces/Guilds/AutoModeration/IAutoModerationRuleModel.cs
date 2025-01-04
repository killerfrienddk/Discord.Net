namespace Discord.Models;

[ModelEquality]
public partial interface IAutoModerationRuleModel : IEntityModel<ulong>
{
    ulong GuildId { get; }
    string Name { get; }
    ulong CreatorId { get; }
    int EventType { get; }
    int TriggerType { get; }
    ITriggerMetadataModel TriggerMetadata { get; }
    IReadOnlyCollection<IAutoModerationActionModel> Actions { get; }
    bool IsEnabled { get; }
    ulong[] ExemptRoles { get; }
    ulong[] ExemptChannels { get; }
}
