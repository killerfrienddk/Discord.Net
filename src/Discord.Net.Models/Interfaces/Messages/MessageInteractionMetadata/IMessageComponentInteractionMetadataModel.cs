namespace Discord.Models;

[ModelEquality]
public partial interface IMessageComponentInteractionMetadataModel :
    IMessageInteractionMetadataModel
{
    ulong InteractedMessageId { get; }
}