using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class VoiceStateUpdated : IExtendedModel<Discord.Models.Json.VoiceState>
{
    Discord.Models.Json.VoiceState IExtendedModel<Discord.Models.Json.VoiceState>.ExtendedValue => VoiceState;

    ulong Discord.Models.IVoiceStateModel.UserId => (VoiceState as Discord.Models.IVoiceStateModel).UserId;

    string Discord.Models.IVoiceStateModel.SessionId => (VoiceState as Discord.Models.IVoiceStateModel).SessionId;

    ulong? Discord.Models.IVoiceStateModel.ChannelId => (VoiceState as Discord.Models.IVoiceStateModel).ChannelId;

    ulong? Discord.Models.IVoiceStateModel.GuildId => (VoiceState as Discord.Models.IVoiceStateModel).GuildId;

    bool Discord.Models.IVoiceStateModel.Deaf => (VoiceState as Discord.Models.IVoiceStateModel).Deaf;

    bool Discord.Models.IVoiceStateModel.Mute => (VoiceState as Discord.Models.IVoiceStateModel).Mute;

    bool Discord.Models.IVoiceStateModel.SelfDeaf => (VoiceState as Discord.Models.IVoiceStateModel).SelfDeaf;

    bool Discord.Models.IVoiceStateModel.SelfMute => (VoiceState as Discord.Models.IVoiceStateModel).SelfMute;

    bool? Discord.Models.IVoiceStateModel.SelfStream => (VoiceState as Discord.Models.IVoiceStateModel).SelfStream;

    bool Discord.Models.IVoiceStateModel.SelfVideo => (VoiceState as Discord.Models.IVoiceStateModel).SelfVideo;

    bool Discord.Models.IVoiceStateModel.Suppress => (VoiceState as Discord.Models.IVoiceStateModel).Suppress;

    System.DateTimeOffset? Discord.Models.IVoiceStateModel.RequestToSpeakTimestamp => (VoiceState as Discord.Models.IVoiceStateModel).RequestToSpeakTimestamp;
}