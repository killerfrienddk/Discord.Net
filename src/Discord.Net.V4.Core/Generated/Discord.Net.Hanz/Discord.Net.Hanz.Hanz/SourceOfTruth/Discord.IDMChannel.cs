using Discord.Models;

namespace Discord;

public partial interface IDMChannel
{
    Discord.Models.IDMChannelModel IEntityOf<IDMChannelModel>.GetModel() => GetModel();

    Discord.Models.IChannelModel IEntityOf<IChannelModel>.GetModel() => GetModel();
}
