using Discord.Models;

namespace Discord;

public partial interface IStageChannel
{
    Discord.Models.IGuildStageChannelModel IEntityOf<IGuildStageChannelModel>.GetModel() => GetModel();

    Discord.Models.IGuildVoiceChannelModel IVoiceChannel.GetModel() => GetModel();

    Discord.Models.IGuildVoiceChannelModel IEntityOf<IGuildVoiceChannelModel>.GetModel() => GetModel();

    Discord.Models.IGuildChannelModel IGuildChannel.GetModel() => GetModel();

    Discord.Models.IGuildChannelModel IEntityOf<IGuildChannelModel>.GetModel() => GetModel();

    Discord.Models.IChannelModel IEntityOf<IChannelModel>.GetModel() => GetModel();
}
