using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;

namespace Discord;

public partial interface IGroupChannel
{
    Discord.Models.IGroupDMChannelModel IEntityOf<IGroupDMChannelModel>.GetModel() => GetModel();

    Discord.Models.IChannelModel IEntityOf<IChannelModel>.GetModel() => GetModel();
}
