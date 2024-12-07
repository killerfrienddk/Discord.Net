

namespace Discord.Models;

public partial interface IGuildScheduledEventUserModel : IEquatable<IGuildScheduledEventUserModel>
{
    new bool Equals(Discord.Models.IGuildScheduledEventUserModel? other)
    {
        if (other is null)
            return false;
        return this.GuildScheduledEventId.Equals(this.GuildScheduledEventId) && this.UserId.Equals(this.UserId);
    }

    bool IEquatable<IGuildScheduledEventUserModel>.Equals(IGuildScheduledEventUserModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IGuildScheduledEventUserModel otherThis && Equals(otherThis);
}