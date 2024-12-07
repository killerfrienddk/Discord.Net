using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed class PartialApplication : IPartial<Discord.Models.Json.Application>, Discord.Models.IPartialApplicationModel, Discord.Models.IEntityModel<ulong>, Discord.Models.IModel, Discord.Models.IModelSourceOfMultiple<IPartialUserModel>, Discord.Models.IModelSourceOf<Discord.Models.IPartialGuildModel?>
{
    [JsonPropertyName("id"), JsonRequired]
    public ulong Id { get; set; }

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

    public bool ApplyTo(Discord.Models.Json.Application model)
    {
        var result = false;
        if (Name.IsSpecified)
        {
            result |= true;
            model.Name = Name.Value;
        }

        if (Icon.IsSpecified)
        {
            result |= true;
            model.Icon = Icon.Value;
        }

        if (Description.IsSpecified)
        {
            result |= true;
            model.Description = Description.Value;
        }

        if (RPCOrigins.IsSpecified)
        {
            result |= true;
            model.RPCOrigins = RPCOrigins.Value;
        }

        if (IsPublicBot.IsSpecified)
        {
            result |= true;
            model.IsPublicBot = IsPublicBot.Value;
        }

        if (BotRequiresCodeGrant.IsSpecified)
        {
            result |= true;
            model.BotRequiresCodeGrant = BotRequiresCodeGrant.Value;
        }

        if (Bot.IsSpecified)
        {
            result |= true;
            model.Bot = Bot.Value;
        }

        if (TermsOfService.IsSpecified)
        {
            result |= true;
            model.TermsOfService = TermsOfService.Value;
        }

        if (PrivacyPolicy.IsSpecified)
        {
            result |= true;
            model.PrivacyPolicy = PrivacyPolicy.Value;
        }

        if (Owner.IsSpecified)
        {
            result |= true;
            model.Owner = Owner.Value;
        }

        if (VerifyKey.IsSpecified)
        {
            result |= true;
            model.VerifyKey = VerifyKey.Value;
        }

        if (Team.IsSpecified)
        {
            result |= true;
            model.Team = Team.Value;
        }

        if (GuildId.IsSpecified)
        {
            result |= true;
            model.GuildId = GuildId.Value;
        }

        if (Guild.IsSpecified)
        {
            result |= true;
            model.Guild = Guild.Value;
        }

        if (PrimarySkuId.IsSpecified)
        {
            result |= true;
            model.PrimarySkuId = PrimarySkuId.Value;
        }

        if (Slug.IsSpecified)
        {
            result |= true;
            model.Slug = Slug.Value;
        }

        if (CoverImage.IsSpecified)
        {
            result |= true;
            model.CoverImage = CoverImage.Value;
        }

        if (Flags.IsSpecified)
        {
            result |= true;
            model.Flags = Flags.Value;
        }

        if (ApproximateGuildCount.IsSpecified)
        {
            result |= true;
            model.ApproximateGuildCount = ApproximateGuildCount.Value;
        }

        if (ApproximateUserInstallCount.IsSpecified)
        {
            result |= true;
            model.ApproximateUserInstallCount = ApproximateUserInstallCount.Value;
        }

        if (RedirectUris.IsSpecified)
        {
            result |= true;
            model.RedirectUris = RedirectUris.Value;
        }

        if (InteractionsEndpointUrl.IsSpecified)
        {
            result |= true;
            model.InteractionsEndpointUrl = InteractionsEndpointUrl.Value;
        }

        if (RoleConnectionsUrl.IsSpecified)
        {
            result |= true;
            model.RoleConnectionsUrl = RoleConnectionsUrl.Value;
        }

        if (Tags.IsSpecified)
        {
            result |= true;
            model.Tags = Tags.Value;
        }

        if (InstallParams.IsSpecified)
        {
            result |= true;
            model.InstallParams = InstallParams.Value;
        }

        if (IntegrationTypesConfig.IsSpecified)
        {
            result |= true;
            model.IntegrationTypesConfig = IntegrationTypesConfig.Value;
        }

        if (CustomInstallUrl.IsSpecified)
        {
            result |= true;
            model.CustomInstallUrl = CustomInstallUrl.Value;
        }

        return result;
    }

    public Type UnderlyingModelType => typeof(Discord.Models.Json.Application);

    public bool Has(string property)
    {
        return property switch
        {
            "Id" => true,
            "Name" => Name.IsSpecified,
            "Icon" => Icon.IsSpecified,
            "Description" => Description.IsSpecified,
            "RPCOrigins" => RPCOrigins.IsSpecified,
            "IsPublicBot" => IsPublicBot.IsSpecified,
            "BotRequiresCodeGrant" => BotRequiresCodeGrant.IsSpecified,
            "Bot" => Bot.IsSpecified,
            "TermsOfService" => TermsOfService.IsSpecified,
            "PrivacyPolicy" => PrivacyPolicy.IsSpecified,
            "Owner" => Owner.IsSpecified,
            "VerifyKey" => VerifyKey.IsSpecified,
            "Team" => Team.IsSpecified,
            "GuildId" => GuildId.IsSpecified,
            "Guild" => Guild.IsSpecified,
            "PrimarySkuId" => PrimarySkuId.IsSpecified,
            "Slug" => Slug.IsSpecified,
            "CoverImage" => CoverImage.IsSpecified,
            "Flags" => Flags.IsSpecified,
            "ApproximateGuildCount" => ApproximateGuildCount.IsSpecified,
            "ApproximateUserInstallCount" => ApproximateUserInstallCount.IsSpecified,
            "RedirectUris" => RedirectUris.IsSpecified,
            "InteractionsEndpointUrl" => InteractionsEndpointUrl.IsSpecified,
            "RoleConnectionsUrl" => RoleConnectionsUrl.IsSpecified,
            "Tags" => Tags.IsSpecified,
            "InstallParams" => InstallParams.IsSpecified,
            "IntegrationTypesConfig" => IntegrationTypesConfig.IsSpecified,
            "CustomInstallUrl" => CustomInstallUrl.IsSpecified,
            _ => false
        };
    }

    public bool TryGet<T>(string property, out T result)
    {
        return property switch
        {
            "Id" when Id is T val => (result = val) is T,
            "Name" when Name is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Icon" when Icon is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Description" when Description is { IsSpecified: true, Value: T val } => (result = val) is T,
            "RPCOrigins" when RPCOrigins is { IsSpecified: true, Value: T val } => (result = val) is T,
            "IsPublicBot" when IsPublicBot is { IsSpecified: true, Value: T val } => (result = val) is T,
            "BotRequiresCodeGrant" when BotRequiresCodeGrant is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Bot" when Bot is { IsSpecified: true, Value: T val } => (result = val) is T,
            "TermsOfService" when TermsOfService is { IsSpecified: true, Value: T val } => (result = val) is T,
            "PrivacyPolicy" when PrivacyPolicy is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Owner" when Owner is { IsSpecified: true, Value: T val } => (result = val) is T,
            "VerifyKey" when VerifyKey is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Team" when Team is { IsSpecified: true, Value: T val } => (result = val) is T,
            "GuildId" when GuildId is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Guild" when Guild is { IsSpecified: true, Value: T val } => (result = val) is T,
            "PrimarySkuId" when PrimarySkuId is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Slug" when Slug is { IsSpecified: true, Value: T val } => (result = val) is T,
            "CoverImage" when CoverImage is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Flags" when Flags is { IsSpecified: true, Value: T val } => (result = val) is T,
            "ApproximateGuildCount" when ApproximateGuildCount is { IsSpecified: true, Value: T val } => (result = val) is T,
            "ApproximateUserInstallCount" when ApproximateUserInstallCount is { IsSpecified: true, Value: T val } => (result = val) is T,
            "RedirectUris" when RedirectUris is { IsSpecified: true, Value: T val } => (result = val) is T,
            "InteractionsEndpointUrl" when InteractionsEndpointUrl is { IsSpecified: true, Value: T val } => (result = val) is T,
            "RoleConnectionsUrl" when RoleConnectionsUrl is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Tags" when Tags is { IsSpecified: true, Value: T val } => (result = val) is T,
            "InstallParams" when InstallParams is { IsSpecified: true, Value: T val } => (result = val) is T,
            "IntegrationTypesConfig" when IntegrationTypesConfig is { IsSpecified: true, Value: T val } => (result = val) is T,
            "CustomInstallUrl" when CustomInstallUrl is { IsSpecified: true, Value: T val } => (result = val) is T,
            _ => (result = default(T)!)is not T
        };
    }

    string? Discord.Models.IPartialApplicationModel.Name => ~Name;

    bool Discord.Models.IPartialApplicationModel.NameIsSpecified => Name.IsSpecified;

    string? Discord.Models.IPartialApplicationModel.Icon => ~Icon;

    bool Discord.Models.IPartialApplicationModel.IconIsSpecified => Icon.IsSpecified;

    string? Discord.Models.IPartialApplicationModel.Description => ~Description;

    bool Discord.Models.IPartialApplicationModel.DescriptionIsSpecified => Description.IsSpecified;

    ulong? Discord.Models.IPartialApplicationModel.BotId => Bot.Map(v => v.Id).ToNullable();

    bool Discord.Models.IPartialApplicationModel.BotIdIsSpecified => Bot.IsSpecified;

    string[]? Discord.Models.IPartialApplicationModel.RPCOrigins => ~RPCOrigins;

    bool Discord.Models.IPartialApplicationModel.RPCOriginsIsSpecified => RPCOrigins.IsSpecified;

    bool? Discord.Models.IPartialApplicationModel.IsPublicBot => IsPublicBot.ToNullable();

    bool Discord.Models.IPartialApplicationModel.IsPublicBotIsSpecified => IsPublicBot.IsSpecified;

    bool? Discord.Models.IPartialApplicationModel.BotRequiresCodeGrant => BotRequiresCodeGrant.ToNullable();

    bool Discord.Models.IPartialApplicationModel.BotRequiresCodeGrantIsSpecified => BotRequiresCodeGrant.IsSpecified;

    string? Discord.Models.IPartialApplicationModel.TermsOfServiceUrl => ~TermsOfService;

    bool Discord.Models.IPartialApplicationModel.TermsOfServiceUrlIsSpecified => TermsOfService.IsSpecified;

    string? Discord.Models.IPartialApplicationModel.PrivacyPolicyUrl => ~PrivacyPolicy;

    bool Discord.Models.IPartialApplicationModel.PrivacyPolicyUrlIsSpecified => PrivacyPolicy.IsSpecified;

    ulong? Discord.Models.IPartialApplicationModel.OwnerId => Owner.Map(v => v.Id).ToNullable();

    bool Discord.Models.IPartialApplicationModel.OwnerIdIsSpecified => Owner.IsSpecified;

    string? Discord.Models.IPartialApplicationModel.VerifyKey => ~VerifyKey;

    bool Discord.Models.IPartialApplicationModel.VerifyKeyIsSpecified => VerifyKey.IsSpecified;

    ulong? Discord.Models.IPartialApplicationModel.TeamId => ~Team.Map(x => x?.Id);

    bool Discord.Models.IPartialApplicationModel.TeamIdIsSpecified => Team.IsSpecified;

    ulong? Discord.Models.IPartialApplicationModel.GuildId => ~GuildId;

    bool Discord.Models.IPartialApplicationModel.GuildIdIsSpecified => GuildId.IsSpecified;

    ulong? Discord.Models.IPartialApplicationModel.PrimarySkuId => ~PrimarySkuId;

    bool Discord.Models.IPartialApplicationModel.PrimarySkuIdIsSpecified => PrimarySkuId.IsSpecified;

    string? Discord.Models.IPartialApplicationModel.Slug => ~Slug;

    bool Discord.Models.IPartialApplicationModel.SlugIsSpecified => Slug.IsSpecified;

    string? Discord.Models.IPartialApplicationModel.CoverImage => ~CoverImage;

    bool Discord.Models.IPartialApplicationModel.CoverImageIsSpecified => CoverImage.IsSpecified;

    int? Discord.Models.IPartialApplicationModel.Flags => ~Flags;

    bool Discord.Models.IPartialApplicationModel.FlagsIsSpecified => Flags.IsSpecified;

    int? Discord.Models.IPartialApplicationModel.ApproximateGuildCount => ~ApproximateGuildCount;

    bool Discord.Models.IPartialApplicationModel.ApproximateGuildCountIsSpecified => ApproximateGuildCount.IsSpecified;

    int? Discord.Models.IPartialApplicationModel.ApproximateUserInstallCount => ~ApproximateUserInstallCount;

    bool Discord.Models.IPartialApplicationModel.ApproximateUserInstallCountIsSpecified => ApproximateUserInstallCount.IsSpecified;

    string[]? Discord.Models.IPartialApplicationModel.RedirectUris => ~RedirectUris;

    bool Discord.Models.IPartialApplicationModel.RedirectUrisIsSpecified => RedirectUris.IsSpecified;

    string? Discord.Models.IPartialApplicationModel.InteractionsEndpointUrl => ~InteractionsEndpointUrl;

    bool Discord.Models.IPartialApplicationModel.InteractionsEndpointUrlIsSpecified => InteractionsEndpointUrl.IsSpecified;

    string? Discord.Models.IPartialApplicationModel.RoleConnectionsVerificationUrl => ~RoleConnectionsUrl;

    bool Discord.Models.IPartialApplicationModel.RoleConnectionsVerificationUrlIsSpecified => RoleConnectionsUrl.IsSpecified;

    string[]? Discord.Models.IPartialApplicationModel.Tags => ~Tags;

    bool Discord.Models.IPartialApplicationModel.TagsIsSpecified => Tags.IsSpecified;

    Discord.Models.IApplicationInstallParamsModel? Discord.Models.IPartialApplicationModel.InstallParams => ~InstallParams;

    bool Discord.Models.IPartialApplicationModel.InstallParamsIsSpecified => InstallParams.IsSpecified;

    Discord.Models.IApplicationIntegrationTypesConfigModel? Discord.Models.IPartialApplicationModel.IntegrationTypesConfig => ~IntegrationTypesConfig;

    bool Discord.Models.IPartialApplicationModel.IntegrationTypesConfigIsSpecified => IntegrationTypesConfig.IsSpecified;

    string? Discord.Models.IPartialApplicationModel.CustomInstallUrl => ~CustomInstallUrl;

    bool Discord.Models.IPartialApplicationModel.CustomInstallUrlIsSpecified => CustomInstallUrl.IsSpecified;

    bool Discord.Models.IPartial<Discord.Models.IApplicationModel>.ApplyTo(Discord.Models.IApplicationModel model) => model is Discord.Models.Json.Application ourModel && ApplyTo(ourModel);
    System.Collections.Generic.IEnumerable<IPartialUserModel> Discord.Models.IModelSourceOfMultiple<IPartialUserModel>.GetModels()
    {
        if (Bot.IsSpecified)
            yield return Bot.Value;
        if (Owner.IsSpecified)
            yield return Owner.Value;
    }

    public IEnumerable<IModel> GetDefinedModels()
    {
        if (Team.IsSpecified && Team.Value is not null)
            yield return Team.Value;
        if (Guild.IsSpecified)
            yield return Guild.Value;
    }

    Discord.Models.IPartialGuildModel? Discord.Models.IModelSourceOf<Discord.Models.IPartialGuildModel?>.Model => ~Guild;
}