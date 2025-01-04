namespace Discord.Models;

public interface IMessageReactionAddedPayload : IGatewayPayloadData
{
    ulong UserId { get; }
    ulong ChannelId { get; }
    ulong MessageId { get; }
    Optional<ulong> GuildId { get; }
    Optional<IMemberModel> Member { get; }
    DiscordEmojiId Emoji { get; }
    Optional<ulong> MessageAuthorId { get; }
    bool IsBurst { get; }
    Optional<string[]> BurstColors { get; }
    int Type { get; }
}
