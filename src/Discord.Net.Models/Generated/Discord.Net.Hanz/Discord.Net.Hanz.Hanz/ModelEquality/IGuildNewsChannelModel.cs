

namespace Discord.Models;

public partial interface IGuildNewsChannelModel : IEquatable<IGuildNewsChannelModel>
{
    new bool Equals(Discord.Models.IGuildNewsChannelModel? other)
    {
        if (other is null)
            return false;
        return this.RatelimitPerUser.Equals(this.RatelimitPerUser) && this.IsNsfw.Equals(this.IsNsfw) && (this.Topic?.Equals(this.Topic) ?? this.Topic is not null) && this.DefaultAutoArchiveDuration.Equals(this.DefaultAutoArchiveDuration) && (this.DefaultThreadRateLimitPerUser?.Equals(this.DefaultThreadRateLimitPerUser) ?? this.DefaultThreadRateLimitPerUser is not null) && this.Name.Equals(this.Name) && this.GuildId.Equals(this.GuildId) && (this.ParentId?.Equals(this.ParentId) ?? this.ParentId is not null) && this.Position.Equals(this.Position) && this.Permissions.Equals(this.Permissions) && (this.Flags?.Equals(this.Flags) ?? this.Flags is not null) && this.Type.Equals(this.Type);
    }

    bool IEquatable<IGuildNewsChannelModel>.Equals(IGuildNewsChannelModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IGuildNewsChannelModel otherThis && Equals(otherThis);
    bool IGuildTextChannelModel.Equals(IGuildTextChannelModel? other) => other is IGuildNewsChannelModel otherThis && Equals(otherThis);
    bool IThreadableChannelModel.Equals(IThreadableChannelModel? other) => other is IGuildNewsChannelModel otherThis && Equals(otherThis);
    bool IGuildChannelModel.Equals(IGuildChannelModel? other) => other is IGuildNewsChannelModel otherThis && Equals(otherThis);
    bool IChannelModel.Equals(IChannelModel? other) => other is IGuildNewsChannelModel otherThis && Equals(otherThis);
}