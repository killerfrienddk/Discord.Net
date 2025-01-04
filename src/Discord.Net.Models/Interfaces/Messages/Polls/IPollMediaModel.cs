namespace Discord.Models;

[ModelEquality]
public partial interface IPollMediaModel : IModel
{
    Optional<string> Text { get; }
    Optional<DiscordEmojiId> Emoji { get; }
}