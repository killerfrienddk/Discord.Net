namespace Discord.Models;

[ModelEquality]
public partial interface IInteractionCallbackResourceModel : IModel
{
    int Type { get; }
    Optional<IActivityInstanceModel> ActivityInstance { get; }
    Optional<ModelOrId<IMessageModel, ulong>> Message { get; }
}