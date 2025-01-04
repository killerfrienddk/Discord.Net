using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialGuildNewsChannelModel : 
    IPartialModel,
    IEntityModel<ulong>,
    Discord.Models.IPartialGuildTextChannelModel,
    Discord.Models.IPartialThreadableChannelModel,
    Discord.Models.IPartialGuildChannelModel,
    Discord.Models.IPartialChannelModel
{
    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IGuildNewsChannelModel);
}
