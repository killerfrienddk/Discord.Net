namespace Discord.Models;

public interface IMessageReactionRemoveAllPayloadData : IGatewayPayloadData
{
    ulong ChannelId { get; }
    ulong MessageId { get; }
    Optional<ulong> GuildId { get; }
}
