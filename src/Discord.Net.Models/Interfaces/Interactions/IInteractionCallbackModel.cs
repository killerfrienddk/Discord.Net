namespace Discord.Models;

[ModelEquality]
public partial interface IInteractionCallbackModel : IEntityModel<ulong>
{
    int Type { get; }
    Optional<string> ActivityInstanceId { get; }
    Optional<ulong> ResponseMessageId { get; }
    Optional<bool> ResponseMessageLoading { get; }
    Optional<bool> ResponseMessageEphemeral { get; }
}