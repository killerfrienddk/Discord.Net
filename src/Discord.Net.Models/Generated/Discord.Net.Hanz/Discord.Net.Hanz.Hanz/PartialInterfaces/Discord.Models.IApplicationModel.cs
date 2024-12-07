

namespace Discord.Models;

public partial interface IPartialApplicationModel : Discord.Models.IPartial<Discord.Models.IApplicationModel>, Discord.Models.IEntityModel<ulong>
{
    string? Name { get; }

    bool NameIsSpecified { get; }

    string? Icon { get; }

    bool IconIsSpecified { get; }

    string? Description { get; }

    bool DescriptionIsSpecified { get; }

    ulong? BotId { get; }

    bool BotIdIsSpecified { get; }

    string[]? RPCOrigins { get; }

    bool RPCOriginsIsSpecified { get; }

    bool? IsPublicBot { get; }

    bool IsPublicBotIsSpecified { get; }

    bool? BotRequiresCodeGrant { get; }

    bool BotRequiresCodeGrantIsSpecified { get; }

    string? TermsOfServiceUrl { get; }

    bool TermsOfServiceUrlIsSpecified { get; }

    string? PrivacyPolicyUrl { get; }

    bool PrivacyPolicyUrlIsSpecified { get; }

    ulong? OwnerId { get; }

    bool OwnerIdIsSpecified { get; }

    string? VerifyKey { get; }

    bool VerifyKeyIsSpecified { get; }

    ulong? TeamId { get; }

    bool TeamIdIsSpecified { get; }

    ulong? GuildId { get; }

    bool GuildIdIsSpecified { get; }

    ulong? PrimarySkuId { get; }

    bool PrimarySkuIdIsSpecified { get; }

    string? Slug { get; }

    bool SlugIsSpecified { get; }

    string? CoverImage { get; }

    bool CoverImageIsSpecified { get; }

    int? Flags { get; }

    bool FlagsIsSpecified { get; }

    int? ApproximateGuildCount { get; }

    bool ApproximateGuildCountIsSpecified { get; }

    int? ApproximateUserInstallCount { get; }

    bool ApproximateUserInstallCountIsSpecified { get; }

    string[]? RedirectUris { get; }

    bool RedirectUrisIsSpecified { get; }

    string? InteractionsEndpointUrl { get; }

    bool InteractionsEndpointUrlIsSpecified { get; }

    string? RoleConnectionsVerificationUrl { get; }

    bool RoleConnectionsVerificationUrlIsSpecified { get; }

    string[]? Tags { get; }

    bool TagsIsSpecified { get; }

    Discord.Models.IApplicationInstallParamsModel? InstallParams { get; }

    bool InstallParamsIsSpecified { get; }

    Discord.Models.IApplicationIntegrationTypesConfigModel? IntegrationTypesConfig { get; }

    bool IntegrationTypesConfigIsSpecified { get; }

    string? CustomInstallUrl { get; }

    bool CustomInstallUrlIsSpecified { get; }
}