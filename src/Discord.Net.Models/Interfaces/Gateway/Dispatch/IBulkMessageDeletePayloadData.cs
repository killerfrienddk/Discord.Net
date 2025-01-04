namespace Discord.Models;

public interface IBulkMessageDeletePayloadData : IGatewayPayloadData
{
    ulong[] Ids { get; }
    ulong ChannelId { get; }
    Optional<ulong> GuildId { get; }
}
