using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialGuildVoiceChannelModel : 
    IPartialModel,
    IEntityModel<ulong>,
    Discord.Models.IPartialGuildChannelModel,
    Discord.Models.IPartialAudioChannelModel,
    Discord.Models.IPartialChannelModel
{
    Discord.Optional<int> RatelimitPerUser { get; }

    Discord.Optional<bool> IsNsfw { get; }

    Discord.Optional<string?> Topic { get; }

    Discord.Optional<int> Bitrate { get; }

    Discord.Optional<int> UserLimit { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IGuildVoiceChannelModel);
}
