namespace Discord.Models;

public interface IMessageDeletePayloadData : IGatewayPayloadData
{
    ulong Id { get; }
    ulong ChannelId { get; }
    Optional<ulong> GuildId { get; }
}
