

namespace Discord.Models;

public partial interface IInteractionModel : IEquatable<IInteractionModel>
{
    new bool Equals(Discord.Models.IInteractionModel? other)
    {
        if (other is null)
            return false;
        return this.ApplicationId.Equals(this.ApplicationId) && this.Type.Equals(this.Type) && (this.Data?.Equals(this.Data) ?? this.Data is not null) && (this.GuildId?.Equals(this.GuildId) ?? this.GuildId is not null) && (this.ChannelId?.Equals(this.ChannelId) ?? this.ChannelId is not null) && (this.UserId?.Equals(this.UserId) ?? this.UserId is not null) && this.Token.Equals(this.Token) && this.Version.Equals(this.Version) && (this.MessageId?.Equals(this.MessageId) ?? this.MessageId is not null) && (this.AppPermissions?.Equals(this.AppPermissions) ?? this.AppPermissions is not null) && (this.Locale?.Equals(this.Locale) ?? this.Locale is not null) && (this.GuildLocale?.Equals(this.GuildLocale) ?? this.GuildLocale is not null) && this.Entitlements.Equals(this.Entitlements) && (this.AuthorizingIntegrationOwners?.Equals(this.AuthorizingIntegrationOwners) ?? this.AuthorizingIntegrationOwners is not null) && this.Context.Equals(this.Context);
    }

    bool IEquatable<IInteractionModel>.Equals(IInteractionModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IInteractionModel otherThis && Equals(otherThis);
}