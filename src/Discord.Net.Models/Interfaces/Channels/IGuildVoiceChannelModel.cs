namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IGuildVoiceChannelModel : IGuildChannelModel, IAudioChannelModel
{
    Optional<int> RatelimitPerUser { get; }
    bool IsNsfw { get; }
    string? Topic { get; }
    int Bitrate { get; }
    Optional<int> UserLimit { get; }
}
