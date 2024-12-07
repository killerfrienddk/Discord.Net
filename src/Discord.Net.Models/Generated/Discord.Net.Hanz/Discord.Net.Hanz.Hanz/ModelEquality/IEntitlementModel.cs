

namespace Discord.Models;

public partial interface IEntitlementModel : IEquatable<IEntitlementModel>
{
    new bool Equals(Discord.Models.IEntitlementModel? other)
    {
        if (other is null)
            return false;
        return this.SkuId.Equals(this.SkuId) && this.ApplicationId.Equals(this.ApplicationId) && (this.UserId?.Equals(this.UserId) ?? this.UserId is not null) && this.Type.Equals(this.Type) && this.IsDeleted.Equals(this.IsDeleted) && (this.StartsAt?.Equals(this.StartsAt) ?? this.StartsAt is not null) && (this.EndsAt?.Equals(this.EndsAt) ?? this.EndsAt is not null) && (this.GuildId?.Equals(this.GuildId) ?? this.GuildId is not null) && (this.Consumed?.Equals(this.Consumed) ?? this.Consumed is not null);
    }

    bool IEquatable<IEntitlementModel>.Equals(IEntitlementModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IEntitlementModel otherThis && Equals(otherThis);
}