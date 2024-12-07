

namespace Discord.Models;

public partial interface IAudioChannelModel : IEquatable<IAudioChannelModel>
{
    new bool Equals(Discord.Models.IAudioChannelModel? other)
    {
        if (other is null)
            return false;
        return (this.RTCRegion?.Equals(this.RTCRegion) ?? this.RTCRegion is not null) && (this.VideoQualityMode?.Equals(this.VideoQualityMode) ?? this.VideoQualityMode is not null) && this.Type.Equals(this.Type);
    }

    bool IEquatable<IAudioChannelModel>.Equals(IAudioChannelModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IAudioChannelModel otherThis && Equals(otherThis);
    bool IChannelModel.Equals(IChannelModel? other) => other is IAudioChannelModel otherThis && Equals(otherThis);
}