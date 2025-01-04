using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialChannelModel : 
    IPartialModel,
    IEntityModel<ulong>
{
    Discord.Optional<int> Type { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IChannelModel);
}
