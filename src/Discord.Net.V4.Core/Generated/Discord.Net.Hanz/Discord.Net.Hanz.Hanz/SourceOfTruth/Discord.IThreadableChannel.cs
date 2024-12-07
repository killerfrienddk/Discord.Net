using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;

namespace Discord;

public partial interface IThreadableChannel
{
    Discord.Models.IThreadableChannelModel IEntityOf<IThreadableChannelModel>.GetModel() => GetModel();

    Discord.Models.IGuildChannelModel IGuildChannel.GetModel() => GetModel();

    Discord.Models.IGuildChannelModel IEntityOf<IGuildChannelModel>.GetModel() => GetModel();

    Discord.Models.IChannelModel IEntityOf<IChannelModel>.GetModel() => GetModel();
}
