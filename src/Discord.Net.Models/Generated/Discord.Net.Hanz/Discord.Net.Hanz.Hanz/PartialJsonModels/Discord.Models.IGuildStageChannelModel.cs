using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialGuildStageChannelModel : 
    IPartialModel,
    IEntityModel<ulong>,
    Discord.Models.IPartialGuildVoiceChannelModel,
    Discord.Models.IPartialGuildChannelModel,
    Discord.Models.IPartialAudioChannelModel,
    Discord.Models.IPartialChannelModel
{
    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IGuildStageChannelModel);
}
