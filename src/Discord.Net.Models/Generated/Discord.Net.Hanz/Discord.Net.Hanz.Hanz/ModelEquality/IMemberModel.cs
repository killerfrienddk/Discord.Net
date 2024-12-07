

namespace Discord.Models;

public partial interface IMemberModel : IEquatable<IMemberModel>
{
    new bool Equals(Discord.Models.IMemberModel? other)
    {
        if (other is null)
            return false;
        return this.Flags.Equals(this.Flags) && (this.Nickname?.Equals(this.Nickname) ?? this.Nickname is not null) && (this.Avatar?.Equals(this.Avatar) ?? this.Avatar is not null) && this.RoleIds.Equals(this.RoleIds) && (this.JoinedAt?.Equals(this.JoinedAt) ?? this.JoinedAt is not null) && (this.PremiumSince?.Equals(this.PremiumSince) ?? this.PremiumSince is not null) && (this.IsPending?.Equals(this.IsPending) ?? this.IsPending is not null) && (this.CommunicationsDisabledUntil?.Equals(this.CommunicationsDisabledUntil) ?? this.CommunicationsDisabledUntil is not null) && (this.AvatarDecoration?.Equals(this.AvatarDecoration) ?? this.AvatarDecoration is not null);
    }

    bool IEquatable<IMemberModel>.Equals(IMemberModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IMemberModel otherThis && Equals(otherThis);
}