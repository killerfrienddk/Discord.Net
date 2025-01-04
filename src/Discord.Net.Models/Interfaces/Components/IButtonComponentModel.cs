using Discord.Models.Json;

namespace Discord.Models;

[ModelEquality]
public partial interface IButtonComponentModel : IMessageComponentModel
{
    int Style { get; }
    Optional<string> Label { get; }
    Optional<DiscordEmojiId> Emote { get; }
    Optional<string> CustomId { get; }
    Optional<ulong> SkuId { get; }
    Optional<string> Url { get; }
    Optional<bool> IsDisabled { get; }
}
