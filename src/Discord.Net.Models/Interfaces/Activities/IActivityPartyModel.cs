namespace Discord.Models;

[ModelEquality]
public partial interface IActivityPartyModel : IModel
{
    Optional<string> Id { get; }
    Optional<IReadOnlyCollection<int>> Size { get; }
}