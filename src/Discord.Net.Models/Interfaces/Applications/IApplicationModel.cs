namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IApplicationModel : IEntityModel<ulong>
{
    string Name { get; }
    string? Icon { get; }
    string Description { get; }
    Optional<string[]> RPCOrigins { get; }
    bool IsPublicBot { get; }
    bool BotRequiresCodeGrant { get; }
    Optional<ModelOrId<IPartialUserModel, ulong>> Bot { get; }
    Optional<string> TermsOfServiceUrl { get; }
    Optional<string> PrivacyPolicyUrl { get; }
    Optional<ModelOrId<IPartialUserModel, ulong>> Owner { get; }
    string VerifyKey { get; }
    ModelOrId<ITeamModel, ulong>? Team { get; }
    Optional<ModelOrId<IPartialGuildModel, ulong>> Guild { get; }
    Optional<ulong> PrimarySkuId { get; }
    Optional<string> Slug { get; }
    Optional<string> CoverImage { get; }
    Optional<int> Flags { get; }
    Optional<int> ApproximateGuildCount { get; }
    Optional<int> ApproximateUserInstallCount { get; }
    Optional<string[]> RedirectUris { get; }
    Optional<string?> InteractionsEndpointUrl { get; }
    Optional<string?> RoleConnectionsVerificationUrl { get; }
    Optional<string?> EventWebhookUrl { get; }
    Optional<int> EventWebhookStatus { get; }
    Optional<string[]> EventWebhookTypes { get; }
    Optional<string[]> Tags { get; }
    Optional<IApplicationInstallParamsModel> InstallParams { get; }
    Optional<IApplicationIntegrationTypesConfigModel> IntegrationTypesConfig { get; }
    Optional<string> CustomInstallUrl { get; }
}
