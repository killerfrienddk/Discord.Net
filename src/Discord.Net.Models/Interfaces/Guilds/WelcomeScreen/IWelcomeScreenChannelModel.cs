namespace Discord.Models;

[ModelEquality]
public partial interface IWelcomeScreenChannelModel : IModel
{
    ulong ChannelId { get; }
    string? Description { get; }
    DiscordEmojiId? Emoji { get; }
}