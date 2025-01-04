namespace Discord.Models;

[ModelEquality]
public partial interface IMessageCallModel : IModel
{
    IReadOnlyCollection<ulong> Participants { get; }
    Optional<DateTimeOffset?> EndedTimestamp { get; }
}