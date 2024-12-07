

namespace Discord.Models;

public partial interface IPresenceModel : IEquatable<IPresenceModel>
{
    new bool Equals(Discord.Models.IPresenceModel? other)
    {
        if (other is null)
            return false;
        return this.UserId.Equals(this.UserId) && (this.GuildId?.Equals(this.GuildId) ?? this.GuildId is not null) && (this.Status?.Equals(this.Status) ?? this.Status is not null) && (this.Activities?.Equals(this.Activities) ?? this.Activities is not null) && (this.ClientStatus?.Equals(this.ClientStatus) ?? this.ClientStatus is not null);
    }

    bool IEquatable<IPresenceModel>.Equals(IPresenceModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IPresenceModel otherThis && Equals(otherThis);
}