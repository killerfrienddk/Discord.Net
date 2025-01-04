using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialGuildTextChannelModel : 
    IPartialModel,
    IEntityModel<ulong>,
    Discord.Models.IPartialThreadableChannelModel,
    Discord.Models.IPartialGuildChannelModel,
    Discord.Models.IPartialChannelModel
{
    Discord.Optional<int> RatelimitPerUser { get; }

    Discord.Optional<bool> IsNsfw { get; }

    Discord.Optional<string?> Topic { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IGuildTextChannelModel);
}
