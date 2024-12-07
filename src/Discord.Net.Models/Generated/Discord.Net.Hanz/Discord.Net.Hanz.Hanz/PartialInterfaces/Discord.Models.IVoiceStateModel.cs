

namespace Discord.Models;

public partial interface IPartialVoiceStateModel : Discord.Models.IPartial<Discord.Models.IVoiceStateModel>, Discord.Models.IEntityModel<ulong>
{
    [PartialIgnore]
    ulong UserId { get; }

    string? SessionId { get; }

    bool SessionIdIsSpecified { get; }

    ulong? ChannelId { get; }

    bool ChannelIdIsSpecified { get; }

    ulong? GuildId { get; }

    bool GuildIdIsSpecified { get; }

    bool? Deaf { get; }

    bool DeafIsSpecified { get; }

    bool? Mute { get; }

    bool MuteIsSpecified { get; }

    bool? SelfDeaf { get; }

    bool SelfDeafIsSpecified { get; }

    bool? SelfMute { get; }

    bool SelfMuteIsSpecified { get; }

    bool? SelfStream { get; }

    bool SelfStreamIsSpecified { get; }

    bool? SelfVideo { get; }

    bool SelfVideoIsSpecified { get; }

    bool? Suppress { get; }

    bool SuppressIsSpecified { get; }

    System.DateTimeOffset? RequestToSpeakTimestamp { get; }

    bool RequestToSpeakTimestampIsSpecified { get; }

    ulong IEntityModel<ulong>.Id => UserId;
}