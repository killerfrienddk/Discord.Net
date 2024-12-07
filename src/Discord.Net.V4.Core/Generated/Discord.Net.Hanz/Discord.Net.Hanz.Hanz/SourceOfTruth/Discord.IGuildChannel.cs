using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;

namespace Discord;

public partial interface IGuildChannel
{
    Discord.Models.IGuildChannelModel IEntityOf<IGuildChannelModel>.GetModel() => GetModel();

    Discord.Models.IChannelModel IEntityOf<IChannelModel>.GetModel() => GetModel();
}
