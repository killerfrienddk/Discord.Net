using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialEmoteModel : 
    IPartialModel,
    IEntityModel<DiscordEmojiId>
{
    Discord.Optional<string> Name { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IEmoteModel);
}
