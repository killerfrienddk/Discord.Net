using System.Numerics;

namespace Discord.Models;

public partial interface IRoleModel : IEquatable<IRoleModel>
{
    new bool Equals(Discord.Models.IRoleModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name) && this.Color.Equals(this.Color) && this.IsHoisted.Equals(this.IsHoisted) && (this.Icon?.Equals(this.Icon) ?? this.Icon is not null) && (this.UnicodeEmoji?.Equals(this.UnicodeEmoji) ?? this.UnicodeEmoji is not null) && this.Position.Equals(this.Position) && this.Permissions.Equals(this.Permissions) && this.IsManaged.Equals(this.IsManaged) && this.IsMentionable.Equals(this.IsMentionable) && this.Flags.Equals(this.Flags) && (this.Tags?.Equals(this.Tags) ?? this.Tags is not null);
    }

    bool IEquatable<IRoleModel>.Equals(IRoleModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IRoleModel otherThis && Equals(otherThis);
}