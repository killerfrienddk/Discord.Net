

namespace Discord.Models;

public partial interface IApplicationModel : IEquatable<IApplicationModel>
{
    new bool Equals(Discord.Models.IApplicationModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name) && (this.Icon?.Equals(this.Icon) ?? this.Icon is not null) && this.Description.Equals(this.Description) && (this.BotId?.Equals(this.BotId) ?? this.BotId is not null) && (this.RPCOrigins?.Equals(this.RPCOrigins) ?? this.RPCOrigins is not null) && this.IsPublicBot.Equals(this.IsPublicBot) && this.BotRequiresCodeGrant.Equals(this.BotRequiresCodeGrant) && (this.TermsOfServiceUrl?.Equals(this.TermsOfServiceUrl) ?? this.TermsOfServiceUrl is not null) && (this.PrivacyPolicyUrl?.Equals(this.PrivacyPolicyUrl) ?? this.PrivacyPolicyUrl is not null) && (this.OwnerId?.Equals(this.OwnerId) ?? this.OwnerId is not null) && this.VerifyKey.Equals(this.VerifyKey) && (this.TeamId?.Equals(this.TeamId) ?? this.TeamId is not null) && (this.GuildId?.Equals(this.GuildId) ?? this.GuildId is not null) && (this.PrimarySkuId?.Equals(this.PrimarySkuId) ?? this.PrimarySkuId is not null) && (this.Slug?.Equals(this.Slug) ?? this.Slug is not null) && (this.CoverImage?.Equals(this.CoverImage) ?? this.CoverImage is not null) && (this.Flags?.Equals(this.Flags) ?? this.Flags is not null) && (this.ApproximateGuildCount?.Equals(this.ApproximateGuildCount) ?? this.ApproximateGuildCount is not null) && (this.ApproximateUserInstallCount?.Equals(this.ApproximateUserInstallCount) ?? this.ApproximateUserInstallCount is not null) && (this.RedirectUris?.Equals(this.RedirectUris) ?? this.RedirectUris is not null) && (this.InteractionsEndpointUrl?.Equals(this.InteractionsEndpointUrl) ?? this.InteractionsEndpointUrl is not null) && (this.RoleConnectionsVerificationUrl?.Equals(this.RoleConnectionsVerificationUrl) ?? this.RoleConnectionsVerificationUrl is not null) && (this.Tags?.Equals(this.Tags) ?? this.Tags is not null) && (this.InstallParams?.Equals(this.InstallParams) ?? this.InstallParams is not null) && (this.IntegrationTypesConfig?.Equals(this.IntegrationTypesConfig) ?? this.IntegrationTypesConfig is not null) && (this.CustomInstallUrl?.Equals(this.CustomInstallUrl) ?? this.CustomInstallUrl is not null);
    }

    bool IEquatable<IApplicationModel>.Equals(IApplicationModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IApplicationModel otherThis && Equals(otherThis);
}