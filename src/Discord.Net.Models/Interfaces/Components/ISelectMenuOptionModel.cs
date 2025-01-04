namespace Discord.Models;

public interface ISelectMenuOptionModel
{
    string Label { get; }
    string Value { get; }
    Optional<string> Description { get; }
    Optional<DiscordEmojiId> Emote { get; }
    Optional<bool> IsDefault { get; }
}
