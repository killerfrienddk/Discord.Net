using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IApplicationModel : 
    IEquatable<Discord.Models.IApplicationModel>
{
    new bool Equals(Discord.Models.IApplicationModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<string?>.Default.Equals(this.Icon, other.Icon) &&
            EqualityComparer<string>.Default.Equals(this.Description, other.Description) &&
            (this.RPCOrigins.IsSpecified == other.RPCOrigins.IsSpecified) && (!this.RPCOrigins.IsSpecified || ((this.RPCOrigins.Value is null == other.RPCOrigins.Value is null) && (this.RPCOrigins.Value is null || this.RPCOrigins.Value.SequenceEqual(other.RPCOrigins.Value!)))) &&
            EqualityComparer<bool>.Default.Equals(this.IsPublicBot, other.IsPublicBot) &&
            EqualityComparer<bool>.Default.Equals(this.BotRequiresCodeGrant, other.BotRequiresCodeGrant) &&
            (this.Bot.IsSpecified == other.Bot.IsSpecified) && (!this.Bot.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<IPartialUserModel, ulong>>.Default.Equals(this.Bot.Value, other.Bot.Value))) &&
            (this.TermsOfServiceUrl.IsSpecified == other.TermsOfServiceUrl.IsSpecified) && (!this.TermsOfServiceUrl.IsSpecified || (EqualityComparer<string>.Default.Equals(this.TermsOfServiceUrl.Value, other.TermsOfServiceUrl.Value))) &&
            (this.PrivacyPolicyUrl.IsSpecified == other.PrivacyPolicyUrl.IsSpecified) && (!this.PrivacyPolicyUrl.IsSpecified || (EqualityComparer<string>.Default.Equals(this.PrivacyPolicyUrl.Value, other.PrivacyPolicyUrl.Value))) &&
            (this.Owner.IsSpecified == other.Owner.IsSpecified) && (!this.Owner.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<IPartialUserModel, ulong>>.Default.Equals(this.Owner.Value, other.Owner.Value))) &&
            EqualityComparer<string>.Default.Equals(this.VerifyKey, other.VerifyKey) &&
            EqualityComparer<Discord.Models.ModelOrId<Discord.Models.ITeamModel, ulong>?>.Default.Equals(this.Team, other.Team) &&
            (this.Guild.IsSpecified == other.Guild.IsSpecified) && (!this.Guild.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<IPartialGuildModel, ulong>>.Default.Equals(this.Guild.Value, other.Guild.Value))) &&
            (this.PrimarySkuId.IsSpecified == other.PrimarySkuId.IsSpecified) && (!this.PrimarySkuId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.PrimarySkuId.Value, other.PrimarySkuId.Value))) &&
            (this.Slug.IsSpecified == other.Slug.IsSpecified) && (!this.Slug.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Slug.Value, other.Slug.Value))) &&
            (this.CoverImage.IsSpecified == other.CoverImage.IsSpecified) && (!this.CoverImage.IsSpecified || (EqualityComparer<string>.Default.Equals(this.CoverImage.Value, other.CoverImage.Value))) &&
            (this.Flags.IsSpecified == other.Flags.IsSpecified) && (!this.Flags.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Flags.Value, other.Flags.Value))) &&
            (this.ApproximateGuildCount.IsSpecified == other.ApproximateGuildCount.IsSpecified) && (!this.ApproximateGuildCount.IsSpecified || (EqualityComparer<int>.Default.Equals(this.ApproximateGuildCount.Value, other.ApproximateGuildCount.Value))) &&
            (this.ApproximateUserInstallCount.IsSpecified == other.ApproximateUserInstallCount.IsSpecified) && (!this.ApproximateUserInstallCount.IsSpecified || (EqualityComparer<int>.Default.Equals(this.ApproximateUserInstallCount.Value, other.ApproximateUserInstallCount.Value))) &&
            (this.RedirectUris.IsSpecified == other.RedirectUris.IsSpecified) && (!this.RedirectUris.IsSpecified || ((this.RedirectUris.Value is null == other.RedirectUris.Value is null) && (this.RedirectUris.Value is null || this.RedirectUris.Value.SequenceEqual(other.RedirectUris.Value!)))) &&
            (this.InteractionsEndpointUrl.IsSpecified == other.InteractionsEndpointUrl.IsSpecified) && (!this.InteractionsEndpointUrl.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.InteractionsEndpointUrl.Value, other.InteractionsEndpointUrl.Value))) &&
            (this.RoleConnectionsVerificationUrl.IsSpecified == other.RoleConnectionsVerificationUrl.IsSpecified) && (!this.RoleConnectionsVerificationUrl.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.RoleConnectionsVerificationUrl.Value, other.RoleConnectionsVerificationUrl.Value))) &&
            (this.EventWebhookUrl.IsSpecified == other.EventWebhookUrl.IsSpecified) && (!this.EventWebhookUrl.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.EventWebhookUrl.Value, other.EventWebhookUrl.Value))) &&
            (this.EventWebhookStatus.IsSpecified == other.EventWebhookStatus.IsSpecified) && (!this.EventWebhookStatus.IsSpecified || (EqualityComparer<int>.Default.Equals(this.EventWebhookStatus.Value, other.EventWebhookStatus.Value))) &&
            (this.EventWebhookTypes.IsSpecified == other.EventWebhookTypes.IsSpecified) && (!this.EventWebhookTypes.IsSpecified || ((this.EventWebhookTypes.Value is null == other.EventWebhookTypes.Value is null) && (this.EventWebhookTypes.Value is null || this.EventWebhookTypes.Value.SequenceEqual(other.EventWebhookTypes.Value!)))) &&
            (this.Tags.IsSpecified == other.Tags.IsSpecified) && (!this.Tags.IsSpecified || ((this.Tags.Value is null == other.Tags.Value is null) && (this.Tags.Value is null || this.Tags.Value.SequenceEqual(other.Tags.Value!)))) &&
            (this.InstallParams.IsSpecified == other.InstallParams.IsSpecified) && (!this.InstallParams.IsSpecified || (EqualityComparer<Discord.Models.IApplicationInstallParamsModel>.Default.Equals(this.InstallParams.Value, other.InstallParams.Value))) &&
            (this.IntegrationTypesConfig.IsSpecified == other.IntegrationTypesConfig.IsSpecified) && (!this.IntegrationTypesConfig.IsSpecified || (EqualityComparer<Discord.Models.IApplicationIntegrationTypesConfigModel>.Default.Equals(this.IntegrationTypesConfig.Value, other.IntegrationTypesConfig.Value))) &&
            (this.CustomInstallUrl.IsSpecified == other.CustomInstallUrl.IsSpecified) && (!this.CustomInstallUrl.IsSpecified || (EqualityComparer<string>.Default.Equals(this.CustomInstallUrl.Value, other.CustomInstallUrl.Value)));
    }
    

    bool IEquatable<Discord.Models.IApplicationModel>.Equals(Discord.Models.IApplicationModel? other) => Equals(other);
}
