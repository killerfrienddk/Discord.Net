using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialAudioChannelModel : 
    IPartialModel,
    IEntityModel<ulong>,
    Discord.Models.IPartialChannelModel
{
    Discord.Optional<string?> RTCRegion { get; }

    Discord.Optional<int> VideoQualityMode { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IAudioChannelModel);
}
