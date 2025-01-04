namespace Discord.Models;

public interface IMessageReactionRemovedPayloadData : IGatewayPayloadData
{
    ulong UserId { get; }
    ulong ChannelId { get; }
    Optional<ulong> GuildId { get; }
    DiscordEmojiId Emoji { get; }
    bool IsBurst { get; }
    int Type { get; }
}
