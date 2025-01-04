using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IMessageRoleSubscriptionData : 
    IEquatable<Discord.Models.IMessageRoleSubscriptionData>
{
    new bool Equals(Discord.Models.IMessageRoleSubscriptionData? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.RoleSubscriptionListingId, other.RoleSubscriptionListingId) &&
            EqualityComparer<string>.Default.Equals(this.TierName, other.TierName) &&
            EqualityComparer<int>.Default.Equals(this.TotalMonthsSubscribed, other.TotalMonthsSubscribed) &&
            EqualityComparer<bool>.Default.Equals(this.IsRenewal, other.IsRenewal);
    }
    

    bool IEquatable<Discord.Models.IMessageRoleSubscriptionData>.Equals(Discord.Models.IMessageRoleSubscriptionData? other) => Equals(other);
}
