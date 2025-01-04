namespace Discord.Models;

public interface IMessageComponentDataModel : IInteractionDataModel
{
    string CustomId { get; }
    int ComponentType { get; }
    Optional<string[]> Values { get; }
    Optional<IResolvedDataModel> Resolved { get; }
}
