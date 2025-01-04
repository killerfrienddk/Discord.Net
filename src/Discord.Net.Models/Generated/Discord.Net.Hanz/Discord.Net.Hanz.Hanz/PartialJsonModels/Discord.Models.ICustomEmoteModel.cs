using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialCustomEmoteModel : 
    IPartialModel,
    IEntityModel<DiscordEmojiId>,
    IEntityModel<ulong>,
    Discord.Models.IPartialEmoteModel
{
    Discord.Optional<ulong[]> Roles { get; }

    Discord.Optional<bool> RequireColons { get; }

    Discord.Optional<bool> IsManaged { get; }

    Discord.Optional<bool> IsAnimated { get; }

    Discord.Optional<bool> IsAvailable { get; }

    Discord.Optional<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>> User { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.ICustomEmoteModel);
}
