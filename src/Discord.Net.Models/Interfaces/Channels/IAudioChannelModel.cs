namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IAudioChannelModel : IChannelModel
{
    Optional<string?> RTCRegion { get; }
    Optional<int> VideoQualityMode { get; }
}
