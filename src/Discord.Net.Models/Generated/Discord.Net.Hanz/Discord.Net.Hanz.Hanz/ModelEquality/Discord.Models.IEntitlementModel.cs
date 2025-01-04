using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IEntitlementModel : 
    IEquatable<Discord.Models.IEntitlementModel>
{
    new bool Equals(Discord.Models.IEntitlementModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.SkuId, other.SkuId) &&
            EqualityComparer<ulong>.Default.Equals(this.ApplicationId, other.ApplicationId) &&
            (this.UserId.IsSpecified == other.UserId.IsSpecified) && (!this.UserId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.UserId.Value, other.UserId.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            EqualityComparer<bool>.Default.Equals(this.IsDeleted, other.IsDeleted) &&
            EqualityComparer<System.DateTimeOffset?>.Default.Equals(this.StartsAt, other.StartsAt) &&
            EqualityComparer<System.DateTimeOffset?>.Default.Equals(this.EndsAt, other.EndsAt) &&
            (this.GuildId.IsSpecified == other.GuildId.IsSpecified) && (!this.GuildId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.GuildId.Value, other.GuildId.Value))) &&
            (this.Consumed.IsSpecified == other.Consumed.IsSpecified) && (!this.Consumed.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.Consumed.Value, other.Consumed.Value)));
    }
    

    bool IEquatable<Discord.Models.IEntitlementModel>.Equals(Discord.Models.IEntitlementModel? other) => Equals(other);
}
