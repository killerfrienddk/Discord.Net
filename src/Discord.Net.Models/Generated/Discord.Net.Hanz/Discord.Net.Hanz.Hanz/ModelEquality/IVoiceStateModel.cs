

namespace Discord.Models;

public partial interface IVoiceStateModel : IEquatable<IVoiceStateModel>
{
    new bool Equals(Discord.Models.IVoiceStateModel? other)
    {
        if (other is null)
            return false;
        return this.UserId.Equals(this.UserId) && this.SessionId.Equals(this.SessionId) && (this.ChannelId?.Equals(this.ChannelId) ?? this.ChannelId is not null) && (this.GuildId?.Equals(this.GuildId) ?? this.GuildId is not null) && this.Deaf.Equals(this.Deaf) && this.Mute.Equals(this.Mute) && this.SelfDeaf.Equals(this.SelfDeaf) && this.SelfMute.Equals(this.SelfMute) && (this.SelfStream?.Equals(this.SelfStream) ?? this.SelfStream is not null) && this.SelfVideo.Equals(this.SelfVideo) && this.Suppress.Equals(this.Suppress) && (this.RequestToSpeakTimestamp?.Equals(this.RequestToSpeakTimestamp) ?? this.RequestToSpeakTimestamp is not null);
    }

    bool IEquatable<IVoiceStateModel>.Equals(IVoiceStateModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IVoiceStateModel otherThis && Equals(otherThis);
}