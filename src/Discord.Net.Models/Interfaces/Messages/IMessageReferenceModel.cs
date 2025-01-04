namespace Discord.Models;

[ModelEquality]
public partial interface IMessageReferenceModel : IModel
{
    Optional<int> Type { get; }
    Optional<ulong> MessageId { get; }
    Optional<ulong> ChannelId { get; }
    Optional<ulong> GuildId { get; }
    Optional<bool> FailIfNotExist { get; }
}