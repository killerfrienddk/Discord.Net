namespace Discord.Models;

public interface ITypingStartPayloadData : IGatewayPayloadData
{
    ulong ChannelId { get; }
    Optional<ulong> GuildId { get; }
    ulong UserId { get; }
    int Timestamp { get; }
    Optional<IMemberModel> Member { get; }
}
