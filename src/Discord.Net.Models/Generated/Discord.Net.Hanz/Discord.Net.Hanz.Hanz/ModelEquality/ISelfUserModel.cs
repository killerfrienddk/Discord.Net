using Discord.Models.Json;
using System.Text.Json.Serialization;

namespace Discord.Models;

public partial interface ISelfUserModel : IEquatable<ISelfUserModel>
{
    new bool Equals(Discord.Models.ISelfUserModel? other)
    {
        if (other is null)
            return false;
        return (this.PremiumType?.Equals(this.PremiumType) ?? this.PremiumType is not null) && (this.Email?.Equals(this.Email) ?? this.Email is not null) && (this.Verified?.Equals(this.Verified) ?? this.Verified is not null) && (this.Locale?.Equals(this.Locale) ?? this.Locale is not null) && (this.MFAEnabled?.Equals(this.MFAEnabled) ?? this.MFAEnabled is not null) && this.Username.Equals(this.Username) && this.Discriminator.Equals(this.Discriminator) && (this.GlobalName?.Equals(this.GlobalName) ?? this.GlobalName is not null) && (this.Avatar?.Equals(this.Avatar) ?? this.Avatar is not null) && (this.IsBot?.Equals(this.IsBot) ?? this.IsBot is not null) && (this.IsSystem?.Equals(this.IsSystem) ?? this.IsSystem is not null) && (this.Flags?.Equals(this.Flags) ?? this.Flags is not null) && (this.PublicFlags?.Equals(this.PublicFlags) ?? this.PublicFlags is not null) && (this.AvatarDecoration?.Equals(this.AvatarDecoration) ?? this.AvatarDecoration is not null);
    }

    bool IEquatable<ISelfUserModel>.Equals(ISelfUserModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is ISelfUserModel otherThis && Equals(otherThis);
    bool IUserModel.Equals(IUserModel? other) => other is ISelfUserModel otherThis && Equals(otherThis);
}