using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialGuildMediaChannelModel : 
    IPartialModel,
    IEntityModel<ulong>,
    Discord.Models.IPartialThreadableChannelModel,
    Discord.Models.IPartialGuildChannelModel,
    Discord.Models.IPartialChannelModel
{
    Discord.Optional<bool> IsNsfw { get; }

    Discord.Optional<string?> Topic { get; }

    Discord.Optional<int> RatelimitPerUser { get; }

    Discord.Optional<Discord.DiscordEmojiId?> DefaultReactionEmoji { get; }

    Discord.Optional<System.Collections.Generic.IEnumerable<Discord.Models.ITagModel>> AvailableTags { get; }

    Discord.Optional<int?> DefaultSortOrder { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IGuildMediaChannelModel);
}
