using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IUserModel : 
    IEquatable<Discord.Models.IUserModel>
{
    new bool Equals(Discord.Models.IUserModel? other)
    {
        if(other is null) return false;
        
        return
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
    

    bool IEquatable<Discord.Models.IUserModel>.Equals(Discord.Models.IUserModel? other) => Equals(other);
}
