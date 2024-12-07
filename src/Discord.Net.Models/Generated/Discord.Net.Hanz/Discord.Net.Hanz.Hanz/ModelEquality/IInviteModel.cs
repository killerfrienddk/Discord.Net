

namespace Discord.Models;

public partial interface IInviteModel : IEquatable<IInviteModel>
{
    new bool Equals(Discord.Models.IInviteModel? other)
    {
        if (other is null)
            return false;
        return this.Type.Equals(this.Type) && this.Code.Equals(this.Code) && (this.GuildId?.Equals(this.GuildId) ?? this.GuildId is not null) && (this.ChannelId?.Equals(this.ChannelId) ?? this.ChannelId is not null) && (this.InviterId?.Equals(this.InviterId) ?? this.InviterId is not null) && (this.TargetType?.Equals(this.TargetType) ?? this.TargetType is not null) && (this.TargetUserId?.Equals(this.TargetUserId) ?? this.TargetUserId is not null) && (this.TargetApplication?.Equals(this.TargetApplication) ?? this.TargetApplication is not null) && (this.ApproximatePresenceCount?.Equals(this.ApproximatePresenceCount) ?? this.ApproximatePresenceCount is not null) && (this.ApproximateMemberCount?.Equals(this.ApproximateMemberCount) ?? this.ApproximateMemberCount is not null) && (this.ExpiresAt?.Equals(this.ExpiresAt) ?? this.ExpiresAt is not null) && (this.ScheduledEventId?.Equals(this.ScheduledEventId) ?? this.ScheduledEventId is not null);
    }

    bool IEquatable<IInviteModel>.Equals(IInviteModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IInviteModel otherThis && Equals(otherThis);
}