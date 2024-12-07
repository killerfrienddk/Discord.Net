

namespace Discord.Models;

public partial interface IUserModel : IEquatable<IUserModel>
{
    new bool Equals(Discord.Models.IUserModel? other)
    {
        if (other is null)
            return false;
        return this.Username.Equals(this.Username) && this.Discriminator.Equals(this.Discriminator) && (this.GlobalName?.Equals(this.GlobalName) ?? this.GlobalName is not null) && (this.Avatar?.Equals(this.Avatar) ?? this.Avatar is not null) && (this.IsBot?.Equals(this.IsBot) ?? this.IsBot is not null) && (this.IsSystem?.Equals(this.IsSystem) ?? this.IsSystem is not null) && (this.Flags?.Equals(this.Flags) ?? this.Flags is not null) && (this.PublicFlags?.Equals(this.PublicFlags) ?? this.PublicFlags is not null) && (this.AvatarDecoration?.Equals(this.AvatarDecoration) ?? this.AvatarDecoration is not null);
    }

    bool IEquatable<IUserModel>.Equals(IUserModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IUserModel otherThis && Equals(otherThis);
}