using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IUserConnectionModel : 
    IEquatable<Discord.Models.IUserConnectionModel>
{
    new bool Equals(Discord.Models.IUserConnectionModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<string>.Default.Equals(this.Type, other.Type) &&
            (this.IsRevoked.IsSpecified == other.IsRevoked.IsSpecified) && (!this.IsRevoked.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsRevoked.Value, other.IsRevoked.Value))) &&
            (this.Integrations.IsSpecified == other.Integrations.IsSpecified) && (!this.Integrations.IsSpecified || (EqualityComparer<System.Collections.Generic.IReadOnlyCollection<IPartialIntegrationModel>>.Default.Equals(this.Integrations.Value, other.Integrations.Value))) &&
            EqualityComparer<bool>.Default.Equals(this.IsVerified, other.IsVerified) &&
            EqualityComparer<bool>.Default.Equals(this.FriendSyncEnabled, other.FriendSyncEnabled) &&
            EqualityComparer<bool>.Default.Equals(this.ShowActivity, other.ShowActivity) &&
            EqualityComparer<bool>.Default.Equals(this.IsTwoWayLink, other.IsTwoWayLink) &&
            EqualityComparer<int>.Default.Equals(this.Visibility, other.Visibility);
    }
    

    bool IEquatable<Discord.Models.IUserConnectionModel>.Equals(Discord.Models.IUserConnectionModel? other) => Equals(other);
}
