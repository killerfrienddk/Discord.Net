using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class PartialApplication : 
    Discord.Models.IPartialApplicationModel
{
    [JsonPropertyName("id")]
    public Discord.Optional<ulong> Id { get; set; }

    [JsonPropertyName("name")]
    public Discord.Optional<string> Name { get; set; }

    [JsonPropertyName("icon")]
    public Discord.Optional<string?> Icon { get; set; }

    [JsonPropertyName("description")]
    public Discord.Optional<string> Description { get; set; }

    [JsonPropertyName("rpc_origins")]
    public Discord.Optional<string[]> RPCOrigins { get; set; }

    [JsonPropertyName("bot_public")]
    public Discord.Optional<bool> IsPublicBot { get; set; }

    [JsonPropertyName("bot_require_code_grant")]
    public Discord.Optional<bool> BotRequiresCodeGrant { get; set; }

    [JsonPropertyName("bot")]
    public Discord.Optional<PartialUser> Bot { get; set; }

    [JsonPropertyName("terms_of_service_url")]
    public Discord.Optional<string> TermsOfService { get; set; }

    [JsonPropertyName("privacy_policy_url")]
    public Discord.Optional<string> PrivacyPolicy { get; set; }

    [JsonPropertyName("owner")]
    public Discord.Optional<PartialUser> Owner { get; set; }

    [JsonPropertyName("verify_key")]
    public Discord.Optional<string> VerifyKey { get; set; }

    [JsonPropertyName("team")]
    public Discord.Optional<Discord.Models.Json.Team?> Team { get; set; }

    [JsonPropertyName("guild_id")]
    public Discord.Optional<ulong> GuildId { get; set; }

    [JsonPropertyName("guild")]
    public Discord.Optional<Discord.Models.Json.PartialGuild> Guild { get; set; }

    [JsonPropertyName("primary_sku_id")]
    public Discord.Optional<ulong> PrimarySkuId { get; set; }

    [JsonPropertyName("slug")]
    public Discord.Optional<string> Slug { get; set; }

    [JsonPropertyName("cover_image")]
    public Discord.Optional<string> CoverImage { get; set; }

    [JsonPropertyName("flags")]
    public Discord.Optional<int> Flags { get; set; }

    [JsonPropertyName("approximate_guild_count")]
    public Discord.Optional<int> ApproximateGuildCount { get; set; }

    [JsonPropertyName("approximate_user_install_count")]
    public Discord.Optional<int> ApproximateUserInstallCount { get; set; }

    [JsonPropertyName("redirect_uris")]
    public Discord.Optional<string[]> RedirectUris { get; set; }

    [JsonPropertyName("interactions_endpoint_url")]
    public Discord.Optional<string> InteractionsEndpointUrl { get; set; }

    [JsonPropertyName("role_connections_verification_url")]
    public Discord.Optional<string> RoleConnectionsUrl { get; set; }

    [JsonPropertyName("tags")]
    public Discord.Optional<string[]> Tags { get; set; }

    [JsonPropertyName("install_params")]
    public Discord.Optional<Discord.Models.Json.InstallParams> InstallParams { get; set; }

    [JsonPropertyName("integration_types_config")]
    public Discord.Optional<Discord.Models.Json.ApplicationIntegrationTypesConfig> IntegrationTypesConfig { get; set; }

    [JsonPropertyName("custom_install_url")]
    public Discord.Optional<string> CustomInstallUrl { get; set; }
}
