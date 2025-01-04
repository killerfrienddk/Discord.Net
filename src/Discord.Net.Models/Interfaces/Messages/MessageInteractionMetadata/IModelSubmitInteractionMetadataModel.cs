namespace Discord.Models;

[ModelEquality]
public partial interface IModelSubmitInteractionMetadataModel : 
    IMessageInteractionMetadataModel
{
    IMessageInteractionMetadataModel TriggeringInteractionMetadata { get; }
}