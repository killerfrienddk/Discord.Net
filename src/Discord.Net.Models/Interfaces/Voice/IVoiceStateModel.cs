namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IVoiceStateModel : IModel
{
    Optional<ulong> GuildId { get; }
    ulong? ChannelId { get; }
    ulong UserId { get; }
    Optional<ModelOrId<IMemberModel, ulong>> Member { get; }
    string SessionId { get; }
    
    bool IsDeafened { get; }
    bool IsMuted { get; }
    
    bool IsSelfDeafened { get; }
    bool IsSelfMuted { get; }
    Optional<bool> IsSelfStreaming { get; }
    bool IsSelfVideo { get; }
    
    bool IsSuppressed { get; }
    
    DateTimeOffset? RequestToSpeakTimestamp { get; }
}
