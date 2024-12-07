

namespace Discord.Models;

public partial interface IPartialGuildModel : IEquatable<IPartialGuildModel>
{
    new bool Equals(Discord.Models.IPartialGuildModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name) && (this.SplashId?.Equals(this.SplashId) ?? this.SplashId is not null) && (this.BannerId?.Equals(this.BannerId) ?? this.BannerId is not null) && (this.Description?.Equals(this.Description) ?? this.Description is not null) && (this.IconId?.Equals(this.IconId) ?? this.IconId is not null) && (this.Features?.Equals(this.Features) ?? this.Features is not null) && (this.VerificationLevel?.Equals(this.VerificationLevel) ?? this.VerificationLevel is not null) && (this.VanityUrlCode?.Equals(this.VanityUrlCode) ?? this.VanityUrlCode is not null) && (this.NsfwLevel?.Equals(this.NsfwLevel) ?? this.NsfwLevel is not null) && (this.PremiumSubscriptionCount?.Equals(this.PremiumSubscriptionCount) ?? this.PremiumSubscriptionCount is not null) && (this.ApproximateMemberCount?.Equals(this.ApproximateMemberCount) ?? this.ApproximateMemberCount is not null) && (this.ApproximatePresenceCount?.Equals(this.ApproximatePresenceCount) ?? this.ApproximatePresenceCount is not null);
    }

    bool IEquatable<IPartialGuildModel>.Equals(IPartialGuildModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IPartialGuildModel otherThis && Equals(otherThis);
}