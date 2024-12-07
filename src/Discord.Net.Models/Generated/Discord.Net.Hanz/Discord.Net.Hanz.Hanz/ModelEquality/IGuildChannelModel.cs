

namespace Discord.Models;

public partial interface IGuildChannelModel : IEquatable<IGuildChannelModel>
{
    new bool Equals(Discord.Models.IGuildChannelModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name) && this.GuildId.Equals(this.GuildId) && (this.ParentId?.Equals(this.ParentId) ?? this.ParentId is not null) && this.Position.Equals(this.Position) && this.Permissions.Equals(this.Permissions) && (this.Flags?.Equals(this.Flags) ?? this.Flags is not null) && this.Type.Equals(this.Type);
    }

    bool IEquatable<IGuildChannelModel>.Equals(IGuildChannelModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IGuildChannelModel otherThis && Equals(otherThis);
    bool IChannelModel.Equals(IChannelModel? other) => other is IGuildChannelModel otherThis && Equals(otherThis);
}