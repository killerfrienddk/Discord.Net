using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IMemberModel : 
    IEquatable<Discord.Models.IMemberModel>
{
    new bool Equals(Discord.Models.IMemberModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.User, other.User) &&
            EqualityComparer<int>.Default.Equals(this.Flags, other.Flags) &&
            (this.Nickname.IsSpecified == other.Nickname.IsSpecified) && (!this.Nickname.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.Nickname.Value, other.Nickname.Value))) &&
            (this.Avatar.IsSpecified == other.Avatar.IsSpecified) && (!this.Avatar.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.Avatar.Value, other.Avatar.Value))) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<ulong>>.Default.Equals(this.Roles, other.Roles) &&
            EqualityComparer<System.DateTimeOffset>.Default.Equals(this.JoinedAt, other.JoinedAt) &&
            (this.PremiumSince.IsSpecified == other.PremiumSince.IsSpecified) && (!this.PremiumSince.IsSpecified || (EqualityComparer<System.DateTimeOffset?>.Default.Equals(this.PremiumSince.Value, other.PremiumSince.Value))) &&
            (this.IsPending.IsSpecified == other.IsPending.IsSpecified) && (!this.IsPending.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsPending.Value, other.IsPending.Value))) &&
            (this.CommunicationsDisabledUntil.IsSpecified == other.CommunicationsDisabledUntil.IsSpecified) && (!this.CommunicationsDisabledUntil.IsSpecified || (EqualityComparer<System.DateTimeOffset?>.Default.Equals(this.CommunicationsDisabledUntil.Value, other.CommunicationsDisabledUntil.Value))) &&
            (this.AvatarDecoration.IsSpecified == other.AvatarDecoration.IsSpecified) && (!this.AvatarDecoration.IsSpecified || (EqualityComparer<Discord.Models.IAvatarDecorationDataModel?>.Default.Equals(this.AvatarDecoration.Value, other.AvatarDecoration.Value)));
    }
    

    bool IEquatable<Discord.Models.IMemberModel>.Equals(Discord.Models.IMemberModel? other) => Equals(other);
}
