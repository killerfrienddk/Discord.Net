using System;

namespace Discord.Models;

public partial interface IStageInstanceModel : IEquatable<IStageInstanceModel>
{
    new bool Equals(Discord.Models.IStageInstanceModel? other)
    {
        if (other is null)
            return false;
        return this.GuildId.Equals(this.GuildId) && this.ChannelId.Equals(this.ChannelId) && this.Topic.Equals(this.Topic) && this.PrivacyLevel.Equals(this.PrivacyLevel) && this.DiscoverableDisabled.Equals(this.DiscoverableDisabled) && (this.EventId?.Equals(this.EventId) ?? this.EventId is not null);
    }

    bool IEquatable<IStageInstanceModel>.Equals(IStageInstanceModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IStageInstanceModel otherThis && Equals(otherThis);
}