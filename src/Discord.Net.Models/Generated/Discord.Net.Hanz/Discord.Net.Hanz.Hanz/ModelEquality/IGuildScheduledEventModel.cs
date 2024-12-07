

namespace Discord.Models;

public partial interface IGuildScheduledEventModel : IEquatable<IGuildScheduledEventModel>
{
    new bool Equals(Discord.Models.IGuildScheduledEventModel? other)
    {
        if (other is null)
            return false;
        return this.GuildId.Equals(this.GuildId) && (this.ChannelId?.Equals(this.ChannelId) ?? this.ChannelId is not null) && this.CreatorId.Equals(this.CreatorId) && this.Name.Equals(this.Name) && (this.Description?.Equals(this.Description) ?? this.Description is not null) && this.ScheduledStartTime.Equals(this.ScheduledStartTime) && (this.ScheduledEndTime?.Equals(this.ScheduledEndTime) ?? this.ScheduledEndTime is not null) && this.PrivacyLevel.Equals(this.PrivacyLevel) && this.Status.Equals(this.Status) && this.EntityType.Equals(this.EntityType) && (this.EntityId?.Equals(this.EntityId) ?? this.EntityId is not null) && (this.UserCount?.Equals(this.UserCount) ?? this.UserCount is not null) && (this.Image?.Equals(this.Image) ?? this.Image is not null) && (this.Location?.Equals(this.Location) ?? this.Location is not null);
    }

    bool IEquatable<IGuildScheduledEventModel>.Equals(IGuildScheduledEventModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IGuildScheduledEventModel otherThis && Equals(otherThis);
}