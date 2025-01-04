namespace Discord.Models;

[ModelEquality]
public partial interface IInteractionCallbackResponseModel : IEntityModel<ulong>
{
    IInteractionCallbackModel Interaction { get; }
    Optional<IInteractionCallbackResourceModel> Resource { get; }

    ulong IEntityModel<ulong>.Id => Interaction.Id;
}