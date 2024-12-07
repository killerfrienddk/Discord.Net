

namespace Discord.Models;

public partial interface IIncomingWebhookModel : IEquatable<IIncomingWebhookModel>
{
    new bool Equals(Discord.Models.IIncomingWebhookModel? other)
    {
        if (other is null)
            return false;
        return this.GuildId.Equals(this.GuildId) && this.ChannelId.Equals(this.ChannelId) && this.Url.Equals(this.Url) && this.Token.Equals(this.Token) && this.Type.Equals(this.Type) && (this.UserId?.Equals(this.UserId) ?? this.UserId is not null) && (this.Name?.Equals(this.Name) ?? this.Name is not null) && (this.Avatar?.Equals(this.Avatar) ?? this.Avatar is not null) && (this.ApplicationId?.Equals(this.ApplicationId) ?? this.ApplicationId is not null);
    }

    bool IEquatable<IIncomingWebhookModel>.Equals(IIncomingWebhookModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IIncomingWebhookModel otherThis && Equals(otherThis);
    bool IWebhookModel.Equals(IWebhookModel? other) => other is IIncomingWebhookModel otherThis && Equals(otherThis);
}