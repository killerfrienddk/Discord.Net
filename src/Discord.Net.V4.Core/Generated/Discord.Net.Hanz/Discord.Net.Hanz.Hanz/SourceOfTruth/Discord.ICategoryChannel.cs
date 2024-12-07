using Discord.Models;

namespace Discord;

public partial interface ICategoryChannel
{
    Discord.Models.IGuildCategoryChannelModel IEntityOf<IGuildCategoryChannelModel>.GetModel() => GetModel();

    Discord.Models.IGuildChannelModel IGuildChannel.GetModel() => GetModel();

    Discord.Models.IGuildChannelModel IEntityOf<IGuildChannelModel>.GetModel() => GetModel();

    Discord.Models.IChannelModel IEntityOf<IChannelModel>.GetModel() => GetModel();
}
