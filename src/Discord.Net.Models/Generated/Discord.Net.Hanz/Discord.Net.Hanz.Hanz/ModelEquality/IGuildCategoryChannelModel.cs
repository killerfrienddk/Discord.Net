

namespace Discord.Models;

public partial interface IGuildCategoryChannelModel : IEquatable<IGuildCategoryChannelModel>
{
    new bool Equals(Discord.Models.IGuildCategoryChannelModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name) && this.GuildId.Equals(this.GuildId) && (this.ParentId?.Equals(this.ParentId) ?? this.ParentId is not null) && this.Position.Equals(this.Position) && this.Permissions.Equals(this.Permissions) && (this.Flags?.Equals(this.Flags) ?? this.Flags is not null) && this.Type.Equals(this.Type);
    }

    bool IEquatable<IGuildCategoryChannelModel>.Equals(IGuildCategoryChannelModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IGuildCategoryChannelModel otherThis && Equals(otherThis);
    bool IGuildChannelModel.Equals(IGuildChannelModel? other) => other is IGuildCategoryChannelModel otherThis && Equals(otherThis);
    bool IChannelModel.Equals(IChannelModel? other) => other is IGuildCategoryChannelModel otherThis && Equals(otherThis);
};