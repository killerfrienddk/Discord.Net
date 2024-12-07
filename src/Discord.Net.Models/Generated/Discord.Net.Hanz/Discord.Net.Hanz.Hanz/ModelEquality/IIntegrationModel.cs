

namespace Discord.Models;

public partial interface IIntegrationModel : IEquatable<IIntegrationModel>
{
    new bool Equals(Discord.Models.IIntegrationModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name) && this.Type.Equals(this.Type) && this.IsEnabled.Equals(this.IsEnabled) && (this.IsSyncing?.Equals(this.IsSyncing) ?? this.IsSyncing is not null) && (this.RoleId?.Equals(this.RoleId) ?? this.RoleId is not null) && (this.EnableEmoticons?.Equals(this.EnableEmoticons) ?? this.EnableEmoticons is not null) && (this.ExpireBehavior?.Equals(this.ExpireBehavior) ?? this.ExpireBehavior is not null) && (this.ExpireGracePeriod?.Equals(this.ExpireGracePeriod) ?? this.ExpireGracePeriod is not null) && (this.UserId?.Equals(this.UserId) ?? this.UserId is not null) && (this.Account?.Equals(this.Account) ?? this.Account is not null) && (this.SyncedAt?.Equals(this.SyncedAt) ?? this.SyncedAt is not null) && (this.SubscriberCount?.Equals(this.SubscriberCount) ?? this.SubscriberCount is not null) && (this.IsRevoked?.Equals(this.IsRevoked) ?? this.IsRevoked is not null) && (this.Application?.Equals(this.Application) ?? this.Application is not null) && (this.Scopes?.Equals(this.Scopes) ?? this.Scopes is not null);
    }

    bool IEquatable<IIntegrationModel>.Equals(IIntegrationModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IIntegrationModel otherThis && Equals(otherThis);
}