using Discord.Models.Json;

namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IGuildForumChannelModel : IThreadableChannelModel
{
    bool IsNsfw { get; }
    string? Topic { get; }
    Optional<int> RatelimitPerUser { get; }
    Optional<DiscordEmojiId?> DefaultReactionEmoji { get; }
    IReadOnlyCollection<ITagModel> AvailableTags { get; }
    int? DefaultSortOrder { get; }
    int DefaultForumLayout { get; }
}
