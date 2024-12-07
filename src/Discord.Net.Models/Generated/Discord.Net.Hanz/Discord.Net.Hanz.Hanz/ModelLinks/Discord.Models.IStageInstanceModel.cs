using System;
using System.Diagnostics.CodeAnalysis;

namespace Discord.Models;

public partial interface IStageInstanceModel : ILinkingModel<ulong, Discord.Models.IGuildModel>, ILinkingModel<ulong, Discord.Models.IChannelModel>, ILinkingModel<ulong>
{
    private bool TryGetIdForGuildId([MaybeNullWhen(false)] out ulong id)
    {
        id = GuildId;
        return true;
    }

    bool ILinkingModel<ulong, Discord.Models.IGuildModel>.TryGetId([MaybeNullWhen(false)] out ulong id) => TryGetIdForGuildId(out id);
    private bool TryGetIdForChannelId([MaybeNullWhen(false)] out ulong id)
    {
        id = ChannelId;
        return true;
    }

    bool ILinkingModel<ulong, Discord.Models.IChannelModel>.TryGetId([MaybeNullWhen(false)] out ulong id) => TryGetIdForChannelId(out id);
    bool ILinkingModel<ulong>.TryGetId(Type modelType, [MaybeNullWhen(false)] out ulong id)
    {
        if (modelType == typeof(Discord.Models.IGuildModel))
            return TryGetIdForGuildId(out id);
        if (modelType == typeof(Discord.Models.IChannelModel))
            return TryGetIdForChannelId(out id);
        id = default;
        return false;
    }
}