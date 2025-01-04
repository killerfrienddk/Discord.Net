using System.Diagnostics.CodeAnalysis;
using Discord.Models.Json;

namespace Discord.Models;

[ModelEquality]
public partial interface IExtendedGuildModel : 
    IGuildCreatePayloadData, 
    IGuildModel
{
    DateTimeOffset JoinedAt { get; }
    bool IsLarge { get; }
    Optional<bool> IsUnavailable { get; }
    int MemberCount { get; }
    IReadOnlyCollection<IPartialVoiceStateModel> VoiceStates { get; }
    IReadOnlyCollection<IMemberModel> Members { get; }
    IReadOnlyCollection<IGuildChannelModel> Channels { get; }
    IReadOnlyCollection<IThreadChannelModel> Threads { get; }
    IReadOnlyCollection<IPresenceModel> Presences { get; }
    IReadOnlyCollection<IStageInstanceModel> StageInstances { get; }
    IReadOnlyCollection<IGuildScheduledEventModel> GuildScheduledEvents { get; }
    IReadOnlyCollection<IGuildSoundboardSoundModel> SoundboardSounds { get; }
}
