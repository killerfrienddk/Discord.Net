

namespace Discord.Models;

public partial interface IWebhookModel : IEquatable<IWebhookModel>
{
    new bool Equals(Discord.Models.IWebhookModel? other)
    {
        if (other is null)
            return false;
        return this.Type.Equals(this.Type) && (this.UserId?.Equals(this.UserId) ?? this.UserId is not null) && (this.Name?.Equals(this.Name) ?? this.Name is not null) && (this.Avatar?.Equals(this.Avatar) ?? this.Avatar is not null) && (this.ApplicationId?.Equals(this.ApplicationId) ?? this.ApplicationId is not null);
    }

    bool IEquatable<IWebhookModel>.Equals(IWebhookModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IWebhookModel otherThis && Equals(otherThis);
}