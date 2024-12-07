

namespace Discord.Models;

public partial interface IThreadChannelModel : IEquatable<IThreadChannelModel>
{
    new bool Equals(Discord.Models.IThreadChannelModel? other)
    {
        if (other is null)
            return false;
        return this.ParentId.Equals(this.ParentId) && this.IsArchived.Equals(this.IsArchived) && this.AutoArchiveDuration.Equals(this.AutoArchiveDuration) && this.ArchiveTimestamp.Equals(this.ArchiveTimestamp) && this.IsLocked.Equals(this.IsLocked) && this.MemberCount.Equals(this.MemberCount) && this.MessageCount.Equals(this.MessageCount) && (this.IsInvitable?.Equals(this.IsInvitable) ?? this.IsInvitable is not null) && this.HasJoined.Equals(this.HasJoined) && (this.CreatedAt?.Equals(this.CreatedAt) ?? this.CreatedAt is not null) && this.AppliedTags.Equals(this.AppliedTags) && this.OwnerId.Equals(this.OwnerId) && this.RatelimitPerUser.Equals(this.RatelimitPerUser) && this.IsNsfw.Equals(this.IsNsfw) && (this.Topic?.Equals(this.Topic) ?? this.Topic is not null) && this.Name.Equals(this.Name) && this.GuildId.Equals(this.GuildId) && this.Position.Equals(this.Position) && this.Permissions.Equals(this.Permissions) && (this.Flags?.Equals(this.Flags) ?? this.Flags is not null) && this.Type.Equals(this.Type);
    }

    bool IEquatable<IThreadChannelModel>.Equals(IThreadChannelModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IThreadChannelModel otherThis && Equals(otherThis);
    bool IGuildChannelModel.Equals(IGuildChannelModel? other) => other is IThreadChannelModel otherThis && Equals(otherThis);
    bool IChannelModel.Equals(IChannelModel? other) => other is IThreadChannelModel otherThis && Equals(otherThis);
}