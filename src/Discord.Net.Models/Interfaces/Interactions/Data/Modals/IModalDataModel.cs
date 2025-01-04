namespace Discord.Models;

[ModelEquality]
public partial interface IModalDataModel : IInteractionDataModel
{
    string CustomId { get; }
    IReadOnlyCollection<IMessageComponentModel> Components { get; }
}
