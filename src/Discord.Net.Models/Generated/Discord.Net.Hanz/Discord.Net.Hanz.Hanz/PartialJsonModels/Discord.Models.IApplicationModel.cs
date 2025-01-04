using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialApplicationModel : 
    IPartialModel,
    IEntityModel<ulong>
{
    Discord.Optional<string> Name { get; }

    Discord.Optional<string?> Icon { get; }

    Discord.Optional<string> Description { get; }

    Discord.Optional<string[]> RPCOrigins { get; }

    Discord.Optional<bool> IsPublicBot { get; }

    Discord.Optional<bool> BotRequiresCodeGrant { get; }

    Discord.Optional<Discord.Models.ModelOrId<IPartialUserModel, ulong>> Bot { get; }

    Discord.Optional<string> TermsOfServiceUrl { get; }

    Discord.Optional<string> PrivacyPolicyUrl { get; }

    Discord.Optional<Discord.Models.ModelOrId<IPartialUserModel, ulong>> Owner { get; }

    Discord.Optional<string> VerifyKey { get; }

    Discord.Optional<Discord.Models.ModelOrId<Discord.Models.ITeamModel, ulong>?> Team { get; }

    Discord.Optional<Discord.Models.ModelOrId<IPartialGuildModel, ulong>> Guild { get; }

    Discord.Optional<ulong> PrimarySkuId { get; }

    Discord.Optional<string> Slug { get; }

    Discord.Optional<string> CoverImage { get; }

    Discord.Optional<int> Flags { get; }

    Discord.Optional<int> ApproximateGuildCount { get; }

    Discord.Optional<int> ApproximateUserInstallCount { get; }

    Discord.Optional<string[]> RedirectUris { get; }

    Discord.Optional<string?> InteractionsEndpointUrl { get; }

    Discord.Optional<string?> RoleConnectionsVerificationUrl { get; }

    Discord.Optional<string?> EventWebhookUrl { get; }

    Discord.Optional<int> EventWebhookStatus { get; }

    Discord.Optional<string[]> EventWebhookTypes { get; }

    Discord.Optional<string[]> Tags { get; }

    Discord.Optional<Discord.Models.IApplicationInstallParamsModel> InstallParams { get; }

    Discord.Optional<Discord.Models.IApplicationIntegrationTypesConfigModel> IntegrationTypesConfig { get; }

    Discord.Optional<string> CustomInstallUrl { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IApplicationModel);
}
