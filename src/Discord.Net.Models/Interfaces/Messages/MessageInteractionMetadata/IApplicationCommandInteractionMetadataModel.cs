namespace Discord.Models;

[ModelEquality]
public partial interface IApplicationCommandInteractionMetadataModel :
    IMessageInteractionMetadataModel
{
    Optional<ModelOrId<IUserModel, ulong>> TargetUser { get; }
    Optional<ulong> TargetMessageId { get; }
}