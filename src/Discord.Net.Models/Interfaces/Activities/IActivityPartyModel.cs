namespace Discord.Models;

[ModelEquality]
public partial interface IActivityPartyModel : IModel
{
    Optional<string> Id { get; }
    Optional<int[]> Size { get; }
}