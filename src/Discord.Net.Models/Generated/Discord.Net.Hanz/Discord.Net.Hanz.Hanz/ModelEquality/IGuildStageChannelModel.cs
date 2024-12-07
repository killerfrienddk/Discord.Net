

namespace Discord.Models;

public partial interface IGuildStageChannelModel : IEquatable<IGuildStageChannelModel>
{
    new bool Equals(Discord.Models.IGuildStageChannelModel? other)
    {
        if (other is null)
            return false;
        return this.RatelimitPerUser.Equals(this.RatelimitPerUser) && this.IsNsfw.Equals(this.IsNsfw) && (this.Topic?.Equals(this.Topic) ?? this.Topic is not null) && this.Bitrate.Equals(this.Bitrate) && (this.UserLimit?.Equals(this.UserLimit) ?? this.UserLimit is not null) && this.Name.Equals(this.Name) && this.GuildId.Equals(this.GuildId) && (this.ParentId?.Equals(this.ParentId) ?? this.ParentId is not null) && this.Position.Equals(this.Position) && this.Permissions.Equals(this.Permissions) && (this.Flags?.Equals(this.Flags) ?? this.Flags is not null) && (this.RTCRegion?.Equals(this.RTCRegion) ?? this.RTCRegion is not null) && (this.VideoQualityMode?.Equals(this.VideoQualityMode) ?? this.VideoQualityMode is not null) && this.Type.Equals(this.Type);
    }

    bool IEquatable<IGuildStageChannelModel>.Equals(IGuildStageChannelModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IGuildStageChannelModel otherThis && Equals(otherThis);
    bool IGuildVoiceChannelModel.Equals(IGuildVoiceChannelModel? other) => other is IGuildStageChannelModel otherThis && Equals(otherThis);
    bool IGuildChannelModel.Equals(IGuildChannelModel? other) => other is IGuildStageChannelModel otherThis && Equals(otherThis);
    bool IAudioChannelModel.Equals(IAudioChannelModel? other) => other is IGuildStageChannelModel otherThis && Equals(otherThis);
    bool IChannelModel.Equals(IChannelModel? other) => other is IGuildStageChannelModel otherThis && Equals(otherThis);
}