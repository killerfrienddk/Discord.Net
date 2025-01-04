namespace Discord.Models;

public interface IMessageReactionRemovedEmojiPayloadData : IGatewayPayloadData
{
    ulong ChannelId { get; }
    Optional<ulong> GuildId { get; }
    ulong MessageId { get; }
    DiscordEmojiId Emoji { get; }
}
