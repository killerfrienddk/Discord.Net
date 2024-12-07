

namespace Discord.Models;

public partial interface IThreadableChannelModel : IEquatable<IThreadableChannelModel>
{
    new bool Equals(Discord.Models.IThreadableChannelModel? other)
    {
        if (other is null)
            return false;
        return this.DefaultAutoArchiveDuration.Equals(this.DefaultAutoArchiveDuration) && (this.DefaultThreadRateLimitPerUser?.Equals(this.DefaultThreadRateLimitPerUser) ?? this.DefaultThreadRateLimitPerUser is not null) && this.Name.Equals(this.Name) && this.GuildId.Equals(this.GuildId) && (this.ParentId?.Equals(this.ParentId) ?? this.ParentId is not null) && this.Position.Equals(this.Position) && this.Permissions.Equals(this.Permissions) && (this.Flags?.Equals(this.Flags) ?? this.Flags is not null) && this.Type.Equals(this.Type);
    }

    bool IEquatable<IThreadableChannelModel>.Equals(IThreadableChannelModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IThreadableChannelModel otherThis && Equals(otherThis);
    bool IGuildChannelModel.Equals(IGuildChannelModel? other) => other is IThreadableChannelModel otherThis && Equals(otherThis);
    bool IChannelModel.Equals(IChannelModel? other) => other is IThreadableChannelModel otherThis && Equals(otherThis);
}