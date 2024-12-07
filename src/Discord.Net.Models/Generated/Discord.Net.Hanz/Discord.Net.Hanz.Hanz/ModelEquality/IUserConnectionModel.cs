

namespace Discord.Models;

public partial interface IUserConnectionModel : IEquatable<IUserConnectionModel>
{
    new bool Equals(Discord.Models.IUserConnectionModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name) && this.Type.Equals(this.Type) && (this.Revoked?.Equals(this.Revoked) ?? this.Revoked is not null) && (this.Integrations?.Equals(this.Integrations) ?? this.Integrations is not null) && this.IsVerified.Equals(this.IsVerified) && this.FriendSyncEnabled.Equals(this.FriendSyncEnabled) && this.ShowActivity.Equals(this.ShowActivity) && this.IsTwoWayLink.Equals(this.IsTwoWayLink) && this.Visibility.Equals(this.Visibility);
    }

    bool IEquatable<IUserConnectionModel>.Equals(IUserConnectionModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IUserConnectionModel otherThis && Equals(otherThis);
}