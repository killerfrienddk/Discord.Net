

namespace Discord.Models;

public partial interface IChannelFollowerWebhookModel : IEquatable<IChannelFollowerWebhookModel>
{
    new bool Equals(Discord.Models.IChannelFollowerWebhookModel? other)
    {
        if (other is null)
            return false;
        return this.GuildId.Equals(this.GuildId) && this.ChannelId.Equals(this.ChannelId) && (this.SourceGuildId?.Equals(this.SourceGuildId) ?? this.SourceGuildId is not null) && (this.SourceGuildName?.Equals(this.SourceGuildName) ?? this.SourceGuildName is not null) && (this.SourceGuildIcon?.Equals(this.SourceGuildIcon) ?? this.SourceGuildIcon is not null) && (this.SourceChannelId?.Equals(this.SourceChannelId) ?? this.SourceChannelId is not null) && (this.SourceChannelName?.Equals(this.SourceChannelName) ?? this.SourceChannelName is not null) && this.Type.Equals(this.Type) && (this.UserId?.Equals(this.UserId) ?? this.UserId is not null) && (this.Name?.Equals(this.Name) ?? this.Name is not null) && (this.Avatar?.Equals(this.Avatar) ?? this.Avatar is not null) && (this.ApplicationId?.Equals(this.ApplicationId) ?? this.ApplicationId is not null);
    }

    bool IEquatable<IChannelFollowerWebhookModel>.Equals(IChannelFollowerWebhookModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IChannelFollowerWebhookModel otherThis && Equals(otherThis);
    bool IWebhookModel.Equals(IWebhookModel? other) => other is IChannelFollowerWebhookModel otherThis && Equals(otherThis);
}