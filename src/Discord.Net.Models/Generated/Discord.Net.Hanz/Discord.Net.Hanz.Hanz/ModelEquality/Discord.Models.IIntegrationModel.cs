using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IIntegrationModel : 
    IEquatable<Discord.Models.IIntegrationModel>
{
    new bool Equals(Discord.Models.IIntegrationModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<string>.Default.Equals(this.Type, other.Type) &&
            EqualityComparer<bool>.Default.Equals(this.IsEnabled, other.IsEnabled) &&
            (this.IsSyncing.IsSpecified == other.IsSyncing.IsSpecified) && (!this.IsSyncing.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsSyncing.Value, other.IsSyncing.Value))) &&
            (this.RoleId.IsSpecified == other.RoleId.IsSpecified) && (!this.RoleId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.RoleId.Value, other.RoleId.Value))) &&
            (this.EnableEmoticons.IsSpecified == other.EnableEmoticons.IsSpecified) && (!this.EnableEmoticons.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.EnableEmoticons.Value, other.EnableEmoticons.Value))) &&
            (this.ExpireBehavior.IsSpecified == other.ExpireBehavior.IsSpecified) && (!this.ExpireBehavior.IsSpecified || (EqualityComparer<int>.Default.Equals(this.ExpireBehavior.Value, other.ExpireBehavior.Value))) &&
            (this.ExpireGracePeriod.IsSpecified == other.ExpireGracePeriod.IsSpecified) && (!this.ExpireGracePeriod.IsSpecified || (EqualityComparer<int>.Default.Equals(this.ExpireGracePeriod.Value, other.ExpireGracePeriod.Value))) &&
            (this.User.IsSpecified == other.User.IsSpecified) && (!this.User.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.User.Value, other.User.Value))) &&
            EqualityComparer<Discord.Models.IIntegrationAccountModel>.Default.Equals(this.Account, other.Account) &&
            (this.SyncedAt.IsSpecified == other.SyncedAt.IsSpecified) && (!this.SyncedAt.IsSpecified || (EqualityComparer<System.DateTimeOffset>.Default.Equals(this.SyncedAt.Value, other.SyncedAt.Value))) &&
            (this.SubscriberCount.IsSpecified == other.SubscriberCount.IsSpecified) && (!this.SubscriberCount.IsSpecified || (EqualityComparer<int>.Default.Equals(this.SubscriberCount.Value, other.SubscriberCount.Value))) &&
            (this.IsRevoked.IsSpecified == other.IsRevoked.IsSpecified) && (!this.IsRevoked.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsRevoked.Value, other.IsRevoked.Value))) &&
            (this.Application.IsSpecified == other.Application.IsSpecified) && (!this.Application.IsSpecified || (EqualityComparer<Discord.Models.IIntegrationApplicationModel>.Default.Equals(this.Application.Value, other.Application.Value))) &&
            (this.Scopes is null == other.Scopes is null) && (this.Scopes is null || this.Scopes.SequenceEqual(other.Scopes!));
    }
    

    bool IEquatable<Discord.Models.IIntegrationModel>.Equals(Discord.Models.IIntegrationModel? other) => Equals(other);
}
