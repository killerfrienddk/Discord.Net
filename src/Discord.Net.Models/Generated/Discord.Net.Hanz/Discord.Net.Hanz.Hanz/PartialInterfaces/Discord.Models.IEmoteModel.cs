using Discord.Converters;
using System.Text.Json.Serialization;

namespace Discord.Models;

public partial interface IPartialEmoteModel : Discord.Models.IPartial<Discord.Models.IEmoteModel>, Discord.Models.IEntityModel<Discord.DiscordEmojiId>
{
    [NullableInPartial]
    string? Name { get; }

    bool NameIsSpecified { get; }
}