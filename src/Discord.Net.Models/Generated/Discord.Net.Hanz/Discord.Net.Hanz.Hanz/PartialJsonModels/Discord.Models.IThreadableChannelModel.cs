using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialThreadableChannelModel : 
    IPartialModel,
    IEntityModel<ulong>,
    Discord.Models.IPartialGuildChannelModel,
    Discord.Models.IPartialChannelModel
{
    Discord.Optional<int> DefaultAutoArchiveDuration { get; }

    Discord.Optional<int> DefaultThreadRateLimitPerUser { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IThreadableChannelModel);
}
