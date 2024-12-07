using Discord.Models.Json;

namespace Discord.Models;

public partial interface IGuildForumChannelModel : IEquatable<IGuildForumChannelModel>
{
    new bool Equals(Discord.Models.IGuildForumChannelModel? other)
    {
        if (other is null)
            return false;
        return this.IsNsfw.Equals(this.IsNsfw) && (this.Topic?.Equals(this.Topic) ?? this.Topic is not null) && (this.RatelimitPerUser?.Equals(this.RatelimitPerUser) ?? this.RatelimitPerUser is not null) && (this.DefaultReactionEmoji?.Equals(this.DefaultReactionEmoji) ?? this.DefaultReactionEmoji is not null) && this.AvailableTags.Equals(this.AvailableTags) && (this.DefaultSortOrder?.Equals(this.DefaultSortOrder) ?? this.DefaultSortOrder is not null) && this.DefaultForumLayout.Equals(this.DefaultForumLayout) && this.DefaultAutoArchiveDuration.Equals(this.DefaultAutoArchiveDuration) && (this.DefaultThreadRateLimitPerUser?.Equals(this.DefaultThreadRateLimitPerUser) ?? this.DefaultThreadRateLimitPerUser is not null) && this.Name.Equals(this.Name) && this.GuildId.Equals(this.GuildId) && (this.ParentId?.Equals(this.ParentId) ?? this.ParentId is not null) && this.Position.Equals(this.Position) && this.Permissions.Equals(this.Permissions) && (this.Flags?.Equals(this.Flags) ?? this.Flags is not null) && this.Type.Equals(this.Type);
    }

    bool IEquatable<IGuildForumChannelModel>.Equals(IGuildForumChannelModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IGuildForumChannelModel otherThis && Equals(otherThis);
    bool IThreadableChannelModel.Equals(IThreadableChannelModel? other) => other is IGuildForumChannelModel otherThis && Equals(otherThis);
    bool IGuildChannelModel.Equals(IGuildChannelModel? other) => other is IGuildForumChannelModel otherThis && Equals(otherThis);
    bool IChannelModel.Equals(IChannelModel? other) => other is IGuildForumChannelModel otherThis && Equals(otherThis);
}