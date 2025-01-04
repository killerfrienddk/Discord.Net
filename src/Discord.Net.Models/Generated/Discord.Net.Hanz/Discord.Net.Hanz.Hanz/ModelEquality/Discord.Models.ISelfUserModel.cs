using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface ISelfUserModel : 
    IEquatable<Discord.Models.ISelfUserModel>
{
    new bool Equals(Discord.Models.ISelfUserModel? other)
    {
        if(other is null) return false;
        
        return
            (this.PremiumType.IsSpecified == other.PremiumType.IsSpecified) && (!this.PremiumType.IsSpecified || (EqualityComparer<int>.Default.Equals(this.PremiumType.Value, other.PremiumType.Value))) &&
            (this.Email.IsSpecified == other.Email.IsSpecified) && (!this.Email.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Email.Value, other.Email.Value))) &&
            (this.IsVerified.IsSpecified == other.IsVerified.IsSpecified) && (!this.IsVerified.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsVerified.Value, other.IsVerified.Value))) &&
            (this.Locale.IsSpecified == other.Locale.IsSpecified) && (!this.Locale.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Locale.Value, other.Locale.Value))) &&
            (this.MFAEnabled.IsSpecified == other.MFAEnabled.IsSpecified) && (!this.MFAEnabled.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.MFAEnabled.Value, other.MFAEnabled.Value))) &&
            EqualityComparer<string>.Default.Equals(this.Username, other.Username) &&
            EqualityComparer<string>.Default.Equals(this.Discriminator, other.Discriminator) &&
            EqualityComparer<string?>.Default.Equals(this.GlobalName, other.GlobalName) &&
            EqualityComparer<string?>.Default.Equals(this.Avatar, other.Avatar) &&
            (this.IsBot.IsSpecified == other.IsBot.IsSpecified) && (!this.IsBot.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsBot.Value, other.IsBot.Value))) &&
            (this.IsSystem.IsSpecified == other.IsSystem.IsSpecified) && (!this.IsSystem.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsSystem.Value, other.IsSystem.Value))) &&
            (this.Flags.IsSpecified == other.Flags.IsSpecified) && (!this.Flags.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Flags.Value, other.Flags.Value))) &&
            (this.PublicFlags.IsSpecified == other.PublicFlags.IsSpecified) && (!this.PublicFlags.IsSpecified || (EqualityComparer<int>.Default.Equals(this.PublicFlags.Value, other.PublicFlags.Value))) &&
            (this.AvatarDecoration.IsSpecified == other.AvatarDecoration.IsSpecified) && (!this.AvatarDecoration.IsSpecified || (EqualityComparer<Discord.Models.IAvatarDecorationDataModel?>.Default.Equals(this.AvatarDecoration.Value, other.AvatarDecoration.Value)));
    }
    

    bool IEquatable<Discord.Models.ISelfUserModel>.Equals(Discord.Models.ISelfUserModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IUserModel>.Equals(Discord.Models.IUserModel? other) => other is Discord.Models.ISelfUserModel self && Equals(self);

    bool Discord.Models.IUserModel.Equals(Discord.Models.IUserModel? other) => other is Discord.Models.ISelfUserModel self && Equals(self);
}
