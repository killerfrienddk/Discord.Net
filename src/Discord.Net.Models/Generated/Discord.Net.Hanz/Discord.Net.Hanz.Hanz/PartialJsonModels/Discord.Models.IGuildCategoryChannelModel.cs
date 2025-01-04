using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialGuildCategoryChannelModel : 
    IPartialModel,
    IEntityModel<ulong>,
    Discord.Models.IPartialGuildChannelModel,
    Discord.Models.IPartialChannelModel
{
    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IGuildCategoryChannelModel);
}
