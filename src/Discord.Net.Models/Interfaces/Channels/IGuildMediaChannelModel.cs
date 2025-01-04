using Discord.Models.Json;

namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IGuildMediaChannelModel : IThreadableChannelModel
{
    bool IsNsfw { get; }
    string? Topic { get; }
    Optional<int> RatelimitPerUser { get; }
    Optional<DiscordEmojiId?> DefaultReactionEmoji { get; }
    IEnumerable<ITagModel> AvailableTags { get; }
    int? DefaultSortOrder { get; }
}
