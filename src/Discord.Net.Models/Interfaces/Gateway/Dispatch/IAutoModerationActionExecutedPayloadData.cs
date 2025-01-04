namespace Discord.Models;

public interface IAutoModerationActionExecutedPayloadData : IGatewayPayloadData
{
    ulong GuildId { get; }
    IAutoModerationActionModel Action { get; }
    ulong RuleId { get; }
    int RuleTriggerType { get; }
    ulong UserId { get; }
    Optional<ulong> ChannelId { get; }
    Optional<ulong> MessageId { get; }
    Optional<ulong> AlertSystemMessageId { get; }
    string Content { get; }
    string? MatchedKeyword { get; }
    string? MatchedContent { get; }
}
