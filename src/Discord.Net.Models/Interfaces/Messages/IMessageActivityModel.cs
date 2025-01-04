namespace Discord.Models;

[ModelEquality]
public partial interface IMessageActivityModel : IModel
{
    int Type { get; }
    Optional<string> PartyId { get; }
}